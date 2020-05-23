#--- Makefile
CC=gcc
CFLAGS= -Wall -std=c99 -pedantic -g  
LIBS = $(shell pkg-config --libs --cflags libmodbus) $(shell pkg-config --libs --cflags mysqlclient) service.c
HEADERS = service.h 
EXECUTABLE = server

.PHONY: clean

start : server 
	./server

server :server.o	
	$(CC) $(CFLAGS) $< -o $@ $(LIBS)

server.o : server.c
	$(CC) -c $< $(LIBS)
	
clean:
	rm -f *.o $(EXECUTABLE)
