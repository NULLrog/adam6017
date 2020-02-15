#--- Makefile
start : server 
	./server

server :server.c	
	gcc server.c -o server $(shell pkg-config --libs --cflags libmodbus) $(shell pkg-config --libs --cflags mysqlclient)
	
