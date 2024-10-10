

CREATE DATABASE PROMOTORES
go

--
USE PROMOTORES

--

drop table Prospecto

Create table Prospectos(
Nombre varchar (50) Primary key,
Primer_Apellido varchar (40) not null,
Segundo_Apellido varchar (40) not null,
Calle varchar (50) not null,
Numero int not null,
Colonia varchar (50) not null,
Codigo_Postal int not null,
Telefono varchar (50) not null,
RFC varchar (50) not null,
Documentos varchar (40)not null,
Estatus varchar (40) not null
)

select * from Prospectos

insert into Prospectos
values('Rodrigo','Medina','Padilla','Severiano',2432,'Chulavista',
80194,'6672513995','JMMP2410ASHSLDFN04','Documentos validos','Enviado')



CREATE TABLE Documentos
(
Nombre_Documentos varchar(50) primary key not null
)

select * from Documentos

insert into Documentos
values ('Documentacion')
CREATE TABLE Estatus_Prospecto
(
Enviado varchar (50) not null,
Autorizado varchar (50) not null,
Rechazado varchar (50) not null
)

select * from Estatus_Prospecto

insert into Estatus_Prospecto
values ('Enviado','Autorizado','Rechazado')
