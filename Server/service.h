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
#include <netinet/tcp.h>
#include <modbus.h>
#include <errno.h>
#include <time.h>
#include <signal.h>
#include <sys/time.h>
#include <arpa/inet.h>
#include <fcntl.h>

#ifndef SERVICE_H
#define SERVICE_H

#define PORT 12345
#define SIZE 1024
#define CLIMAX 20

struct adam6017 {
    struct tm tm;
    double ch[8];
};

struct adam6017 *shm;
struct adam6017 chanels;

int flag;
int shmid;
int sockfd, newsockfd;
char buff[SIZE];

void handle_sigint(int sig);
void handle_info(int sig);
void handle_kill(int sig);
void attach();
void detach();
void finish_with_error(MYSQL *con);

#endif
