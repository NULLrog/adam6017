#include "service.h"

void dbsend(MYSQL *con) {
    while(1) {
        if(flag) {
            attach();
            chanels = *shm;
            detach();
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
            flag = 0;
        }
    }
}

void get_val (int sock) {
    int n, status;
    int ch;
    ch = atoi(buff);
    printf("Get Ch-%d\n", ch);
    attach();
    double val = shm->ch[ch];
    detach();
    printf("Ch-%d return %f v\n", ch, val);
    snprintf(buff, sizeof(buff), "%f", val);
    send(sock, &buff, strlen(buff), 0);
}

void adam (MYSQL *con, int pid_sql, int pid_cli) {
    modbus_t *ctx = modbus_new_tcp("192.168.10.10", MODBUS_TCP_DEFAULT_PORT);
    if (modbus_connect(ctx) == -1) {
        fprintf(stderr, "Modbus connection failed: %s\n", modbus_strerror(errno));
        modbus_free(ctx);
        kill(pid_cli, SIGKILL);
        exit(-7);
    }
    int rc;
    double t;
    double v;
    while(1) {
        time_t t = time(NULL);
        struct tm tm = *localtime(&t);
        uint16_t tab_reg[64];
        rc = modbus_read_registers(ctx, 0, 8, tab_reg);
        if (rc == -1) {
            fprintf(stderr, "%s\n", modbus_strerror(errno));
            kill(pid_cli, SIGKILL);
            exit(-8);
        }
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
        kill(pid_sql, SIGUSR1);
        sleep(1);
    }
}

void client() {
    signal(SIGINT, handle_sigint);
    int client_socket[CLIMAX];
    int activity, sd, n;
    int max_sd;
    socklen_t clilen;
    fd_set readfds;
    fd_set readin;
    struct sockaddr_in serv_addr, cli_addr;
    for (int i =0 ; i <  CLIMAX; i++) {
        client_socket[i] = 0;
    }
    if ((sockfd = socket(AF_INET, SOCK_STREAM, 0)) < 0) {
        perror("socket()\n");
        exit(-3);
    }
    int f = 1;
    if (setsockopt(sockfd, SOL_SOCKET, SO_REUSEADDR, &f, sizeof(f)) < 0) {
        perror("setsockopt(SO_REUSEADDR)\n");
        exit(-4);
    }

    serv_addr.sin_family = AF_INET;
    serv_addr.sin_addr.s_addr = INADDR_ANY;
    serv_addr.sin_port = htons(PORT);

    if (bind(sockfd, (struct sockaddr *) &serv_addr, sizeof(serv_addr)) < 0) {
        perror("bind()\n");
        exit(-5);
    }
    listen(sockfd, CLIMAX);
    clilen = sizeof(cli_addr);
    while (1) {
        FD_ZERO(&readfds);
        FD_SET(sockfd, &readfds);
        max_sd = sockfd;
        for (int i = 0 ; i < CLIMAX; i++) {
            sd = client_socket[i];
            if(sd > 0)
                FD_SET(sd, &readfds);
            if(sd > max_sd)
                max_sd = sd;
        }
        select( max_sd + 1, &readfds, NULL, NULL, NULL);
        if (FD_ISSET(sockfd, &readfds)) {
            if ((newsockfd = accept(sockfd,(struct sockaddr *) &cli_addr, &clilen))<0) {
                perror("accept()\n");
                exit(-6);
            }
            char str1[] = "Welcom to ADAM's server!";
            send(newsockfd, &str1, strlen(str1), 0);
            for (int i = 0; i < CLIMAX; i++) {
                if( client_socket[i] == 0 ) {
                    client_socket[i] = newsockfd;
                    break;
                }
            }
        }
        for (int i = 0; i < CLIMAX; i++) {
            sd = client_socket[i];
            memset(buff, 0, sizeof(buff));
            if (FD_ISSET(sd, &readfds)) {
                if ((n = recv(sd, &buff[0], sizeof(buff), 0)) == 0) {
                    printf("Sock %d disconnected\n", sd);
                    fflush(stdout);
                    close(sd);
                    client_socket[i] = 0;
                } else {
                    buff[n] = '\0';
                    get_val(sd);
                    memset(buff, 0, sizeof(buff));
                }
            }
        }
    }
}

int main(int argc, char **argv) {
    printf("SERVER: start\n");
    signal(SIGUSR1, handle_info);
    signal(SIGKILL, handle_kill);
    flag = 0;
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
        perror("shmget()\n");
        exit(-2);
    }
    int pid_cli = fork();
    if (pid_cli < 0)
        exit(-1);
    if (pid_cli == 0) {
        client();
        exit(0);
    }
    int pid_sql = fork();
    if (pid_sql < 0)
        exit(-1);
    if (pid_sql == 0) {
        dbsend(con);
        exit(0);
    }
    adam(con, pid_sql, pid_cli);
    mysql_close(con);
    exit(0);
}
