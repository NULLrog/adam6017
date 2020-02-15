create database adam;
use adam;

/*Test inserting*/
insert into ch0 (dt, value) values ('2020-01-01', 1); 

/*Similarly, tables are created for other channels*/
create table ch7
(
	id int primary key auto_increment,
	dt datetime not null,
	value double not null
);

select * from ch7;