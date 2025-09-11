create database aaa;
use aaa;

create table campos2(
id int primary key identity,
fecha datetime,
codigofac int,
nombreyapellido varchar(100),
edad varchar(100),
eg varchar(100),
referencia varchar(100),
telefonos int,
motivo varchar(100),
diagnostico varchar(100),
agendar int,
ecg int,
eco int,
tt int,
fetal int,
holter int,
consulta varchar(100),
medico varchar(100)
);
drop table campos2;

--insert into campos1(fecha, codigofac, nombreyapellido, edad, eg, referencia, telefonos, motivo, diagnostico, agendar, 
--ecg, eco, tt, fetal, holter, consulta, medico) 
--values();

select * from campos2;
