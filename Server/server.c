#include <my_global.h>
#include <mysql.h>
#include <stdio.h>
#include <stdio.h>
#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <string.h>
#include <sys/types.h>
#include <sys/wait.h>
#include <sys/ipc.h>
#include <sys/shm.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <modbus.h>
#include <errno.h>
#include <time.h>

#define PORT 12345
#define SIZE 1024

struct adam6017 {
    struct tm tm;
    double ch[8];
};

struct adam6017 *shm;
int shmid;

void attach() {
    if ((shm = (struct adam6017 *)shmat(shmid, NULL, 0)) == (struct adam6017 *) -1) {
        perror("Не удалось получить доступ к разделяемой памяти!\n");
        exit(-5);
    }
}

void detach() {
    if (shmdt(shm) < 0) {
        printf("Ошибка отключения\n");
        exit(-6);
    }
}

void finish_with_error(MYSQL *con) {
    fprintf(stderr, "%s\n", mysql_error(con));
    mysql_close(con);
    exit(-7);
}

void dbsend(struct adam6017 chanels, MYSQL *con) {
    char buffer[100];
    memset(buffer, 0, sizeof(buffer));
    for(int i = 0; i < 8; i++) {
        snprintf ( buffer, 100, "insert into ch%d (dt, value) values ('%d-%02d-%02d %02d:%02d:%02d', '%f')",
                   i, chanels.tm.tm_year + 1900, chanels.tm.tm_mon + 1, chanels.tm.tm_mday, chanels.tm.tm_hour,
                   chanels.tm.tm_min, chanels.tm.tm_sec, chanels.ch[i]);
        if (mysql_query(con, buffer)) {
            finish_with_error(con);
        }
    }
}

void get_val (int sock) {
    int n, status;
    int ch;
    char buff[SIZE];
    memset(buff, 0, sizeof(buff));
    char str1[] = "Добро пожаловать на сервер ADAM!";
    send(sock, &str1, strlen(str1), 0);
    while(1) {
		memset(buff, 0, sizeof(buff));
        if (((n = recv(sock, &buff[0], sizeof(buff), 0)) < 0)) {
            perror("Передача была оборвана!\n");
            exit(-1);
        }
        if (strcmp(buff, "exit") == 0) {
            printf("КЛИЕНТ: ушел!\n");
            return;
        }
        ch = atoi(buff);
        printf("Получить канал %d\n", ch);
        attach();
        double val = shm->ch[ch];
        detach();
        printf("Запрос на Ch-%d вернул %f v\n", ch, val);
        snprintf(buff, sizeof(buff), "%f", val);
        send(sock, &buff, strlen(buff), 0);
    }
}

void adam (MYSQL *con) {
    modbus_t *ctx;
    int rc;
    double t;
    double v;
    while(1) {
        time_t t = time(NULL);
        struct tm tm = *localtime(&t);
        uint16_t tab_reg[64];
        ctx = modbus_new_tcp("192.168.10.10", 502);
        if (modbus_connect(ctx) == -1) {
            fprintf(stderr, "Connection failed: %s\n", modbus_strerror(errno));
            modbus_free(ctx);
            exit(-3);
        }
        rc = modbus_read_registers(ctx, 0, 8, tab_reg);
        if (rc == -1) {
            fprintf(stderr, "%s\n", modbus_strerror(errno));
            exit(-4);
        }
        struct adam6017 chanels;
        chanels.tm = tm;
        for (int i=0; i < rc; i++) {
            t = tab_reg[i] - 32768;
            v = (10/32768.)*(t);
            chanels.ch[i] = v;
            printf("ch%d %d-%02d-%02d %02d:%02d:%02d value %f\n", i, tm.tm_year + 1900, tm.tm_mon + 1, tm.tm_mday, tm.tm_hour, tm.tm_min, tm.tm_sec, v);
        }
        puts("\n");
        attach();
        *shm = chanels;
        detach();
        int pid = fork();
        if (pid < 0)
            exit(-1);
        if (pid == 0) {
            dbsend(chanels, con);
            exit(0);
        }
        modbus_close(ctx);
        modbus_free(ctx);
        sleep(1);
    }
}

void client() {
	int sockfd, newsockfd;
    socklen_t clilen;
    int pid;
    struct sockaddr_in serv_addr, cli_addr;
    if ((sockfd = socket(AF_INET, SOCK_STREAM, 0))<0) {
        perror("Сокет не был создал!\n");
        exit(-1);
    }
    serv_addr.sin_family = AF_INET;
    serv_addr.sin_addr.s_addr = INADDR_ANY;
    serv_addr.sin_port = htons(PORT);

    if (bind(sockfd, (struct sockaddr *) &serv_addr, sizeof(serv_addr)) < 0) {
        perror("Сокет не был привязан!\n");
        exit(-1);
    }
    listen(sockfd,5);
    clilen = sizeof(cli_addr);
    while (1) {
        if ((newsockfd = accept(sockfd,(struct sockaddr *) &cli_addr, &clilen)) < 0) {
            perror("Установка связи с клиентом оборвана!!\n");
            exit(-1);
        }
        printf("КЛИЕНТ: пришел\n");
        pid = fork();
        if (pid < 0)
            exit(-1);
        if (pid == 0) {
            get_val(newsockfd);
            close(sockfd);
            exit(0);
        } else
            close(newsockfd);
    }
    close(sockfd);
}

int main(int argc, char **argv) {
    printf("СЕРВЕР: начало работы\n");
    MYSQL *con = mysql_init(NULL);
    if (con == NULL) {
        fprintf(stderr, "%s\n", mysql_error(con));
        exit(-1);
    }
    if (mysql_real_connect(con, "localhost", "root", "password", "adam", 0, NULL, 0) == NULL) {
        finish_with_error(con);
    }
    key_t key = ftok("Makefile", 'k');
    if ((shmid = shmget(key, sizeof(struct adam6017), IPC_CREAT | 0666)) < 0) {
        perror("Не удалось создать область разделяемой памяти!\n");
        exit(-2);
    }
    int pid = fork();
    if (pid < 0)
        exit(-1);
    if (pid == 0) {
        client();
        exit(0);
    }
    adam(con);
    mysql_close(con);
    exit(0);
}
