drop table worker
create table worker
(
id int identity(1,1),
username varchar(32),
tel char(11),
password  char(32),
duty varchar(32) CHECK (duty='repairer' or duty='admin'),
PRIMARY KEY (id)
)