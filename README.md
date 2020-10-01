# Adam6017
The purpose of this repo is to design a complex of applications for collecting and processing data from an analog-to-digital converter of the Adam-6000 series.
Repo include:
- Server based on the operating system (OS) Linux (Ubuntu 20.04);
- Client based on Windows OS (Windows 10).
The following libraries are used in the Server application: libmodbus, libmysqlclient.
The Server was written in C, which allows the use of interprocess communication (IPC) methods. The Linux-integrated tool, System V, was chosen as the IPC communication tool. To build, use the Make tool.
Mysql was chosen as the data warehouse.
The Client application was written in the C# programming language.

Have a fun!
