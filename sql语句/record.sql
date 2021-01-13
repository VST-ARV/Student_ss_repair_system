drop table record
create table record
(
recordno int identity(1,1) PRIMARY KEY ,
name varchar(32),
no char(10),
domno varchar(32),
tel char(11),
item varchar(32),
details varchar(255),
time datetime,
isrpd int
)