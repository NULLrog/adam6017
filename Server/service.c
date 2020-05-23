#include "service.h"

void handle_sigint(int sig) {
    printf("\nBuy!");
    close(sockfd);
    close(newsockfd);
    exit(0);
}

void handle_info(int sig) {
    flag = 1;
}

void handle_kill(int sig) {
    close(sockfd);
    close(newsockfd);
    exit(-10);
}

void attach() {
    if ((shm = (struct adam6017 *)shmat(shmid, NULL, 0)) == (struct adam6017 *) -1) {
        perror("shmat()\n");
        exit(-5);
    }
}

void detach() {
    if (shmdt(shm) < 0) {
        perror("shmdt()\n");
        exit(-6);
    }
}

void finish_with_error(MYSQL *con) {
    fprintf(stderr, "%s\n", mysql_error(con));
    mysql_close(con);
    exit(-7);
}
