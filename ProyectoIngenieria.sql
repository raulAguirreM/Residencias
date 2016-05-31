CREATE DATABASE Proyecto

CREATE TABLE Alumnos(
Matricula int PRIMARY KEY NOT NULL,
Nombre VARCHAR(30) NOT NULL,
ApP VARCHAR (30) NOT NULL,
ApM VARCHAR (30) NOT NULL,
Carrera VARCHAR(20) NOT NULL,
Telefono VARCHAR(10),
Correo VARCHAR(50),
NombreProyecto VARCHAR(80),
Empresa VARCHAR(30))

CREATE TABLE Asesores(
Id INT IDENTITY (000,1) PRIMARY KEY NOT NULL,
Nombre VARCHAR(30) NOT NULL,
ApP VARCHAR (30) NOT NULL,
ApM VARCHAR(30) NOT NULL,
Tipo VARCHAR(20) NOT NULL,
Telefono VARCHAR (10),
Correo VARCHAR(50),
Profesion VARCHAR(30))

CREATE TABLE Citas(
Clave INT IDENTITY (1000,1) PRIMARY KEY,
Matricula INT NOT NULL,
Id INT NOT NULL,
Hora DATETIME NOT NULL)

alter table Citas add foreign key (Matricula) references Alumnos(Matricula)
alter table Citas add foreign key (ID) references Asesores(ID)

CREATE TABLE Documentacion(
Folio INT IDENTITY (2000,1) PRIMARY KEY,
Solicitud BIT,
Anteproyecto BIT,
Carta BIT,
Dictamen BIT,
Asignacion BIT,
AsesorExt BIT,
Seguimiento BIT,
Registro Bit,
CartaAgradecimiento BIT, 
CDInforme BIT,
CDRes Bit,
CartaAcep BIT)

CREATE TABLE REQUISITOS(
Matricula INT NOT NULL,
Servicio BIT,
Creditos BIT,
Extra BIT)



