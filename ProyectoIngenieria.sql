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

create procedure AgregaUsusario
@usuario varchar (30),
@contraseña varchar (30),
@tipo varchar (20)
as 
insert into Usuario (usuario, contraseña, tipo) values (@usuario, @contraseña, @tipo)

--AGREGAR ALUMNOS
create proc AgregarAlumnos
@Matricula int,
@Nombre varchar (30),
@ApP varchar (30),
@ApM varchar (30),
@Carrera varchar (20),
@Telefono varchar (10),
@Correo varchar (50),
@NombreProyecto varchar (80),
@Empresa varchar (30)
as 
insert into Alumnos (Matricula, Nombre, ApP, ApM, Carrera, Telefono, Correo, NombreProyecto, Empresa) values (@Matricula,@Nombre, @ApP, @ApM, @Carrera, @Telefono, @Correo, @NombreProyecto, @Empresa)

--AGREGAR ASESORES
create proc AgregarAsesores
@Id int, 
@Nombre varchar (30),
@ApP varchar (30),
@ApM varchar (30),
@Tipo varchar (20),
@Telefono varchar (10),
@Correo varchar (50),
@Profesion varchar (30)
as
insert into Asesores (Id, Nombre, ApP, ApM, Tipo, Telefono, Correo, Profesion) values (@Id, @Nombre, @ApP, @ApM, @Tipo, @Telefono, @Correo, @Profesion)

--AGREGAR CITAS
create proc AgregarCitas
@Clave int,
@Matricula int,
@Id int,
@Hora datetime
as 
insert into Citas (Clave, Matricula, Id,Hora) values (@Clave, @Matricula, @Id, @Hora)

--AGREGAR DOCUMENTACION
create proc AgregarDocumentacion
@Folio int, 
@Solicitud bit,
@Anteproyecto bit,
@Carta bit,
@Dictamen bit,
@Asignacion bit,
@AsesorExt bit,
@Seguimiento bit,
@Registro bit,
@CartaAgradecimiento bit,
@CDInforme bit,
@CDRes bit,
@CartaAcep bit
as
insert into Documentacion (Folio, Solicitud, Anteproyecto, Carta, Dictamen, Asignacion, AsesorExt, Seguimiento, Registro, CartaAgradecimiento, CDInforme, CDRes, CartaAcep) values (@Folio, @Solicitud, @Anteproyecto, @Carta, @Dictamen, @Asignacion, @AsesorExt, @Seguimiento, @Registro, @CartaAgradecimiento, @CDInforme, @CDRes, @CartaAcep)

--AGREAGAR REQUISITOS
create proc AgregarRequisistos
@Matricula int, 
@Servicio bit, 
@Creditos bit, 
@Extra bit
as
insert into REQUISITOS (Matricula, Servicio, Creditos, Extra) values ( @Matricula, @Servicio, @Creditos, @Extra)

--CREACION TABLA USUARIOS
create table Usuarios(
id int primary key identity,
usuario int,
contraseña varchar (30),
tipo varchar (30))

--AGREGAR USUARIO
create proc AgregarUsuario
@id int, 
@usuario int, 
@contraseña varchar (30),
@tipo varchar (30)
as 
insert into Usuarios (id, usuario, contraseña, tipo) values (@id, @usuario, @contraseña, @tipo) 

------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------

--MODIFICAR ALUMNOS
create proc modAlumnos
@Matricula int,
@Nombre varchar (30),
@ApP varchar (30),
@ApM varchar (30),
@Carrera varchar (20),
@Telefono varchar (10),
@Correo varchar (50),
@NombreProyecto varchar (80),
@Empresa varchar (30)
as begin
	update Alumnos set  Nombre=@Nombre, ApP=@ApP, ApM=@ApM, Carrera=@Carrera, Telefono=@Telefono, Correo=@Correo, NombreProyecto=@NombreProyecto, Empresa=@Empresa
	where Matricula =@Matricula
	end

--MODIFICAR ASESORES
create proc modAsesores
@Id int, 
@Nombre varchar (30),
@ApP varchar (30),
@ApM varchar (30),
@Tipo varchar (20),
@Telefono varchar (10),
@Correo varchar (50),
@Profesion varchar (30)
as begin
	update Asesores set Nombre=@Nombre, ApP=@ApP, ApM=@ApM, Tipo=@Tipo, Telefono=@Telefono, Correo=@Correo, Profesion=@Profesion
	where Id=@Id
	end
--MODIFICAR CITAS
create proc modCitas
@Clave int,
@Matricula int,
@Id int,
@Hora datetime
as begin 
	update Citas set Matricula=@Matricula, Id=@Id, Hora=@Hora
	where Clave=@Clave
	end

--MODIFICAR DOCUMENTACION
create proc modDocumentacion
@Folio int, 
@Solicitud bit,
@Anteproyecto bit,
@Carta bit,
@Dictamen bit,
@Asignacion bit,
@AsesorExt bit,
@Seguimiento bit,
@Registro bit,
@CartaAgradecimiento bit,
@CDInforme bit,
@CDRes bit,
@CartaAcep bit
as begin	
	update Documentacion set Solicitud=@Solicitud, Anteproyecto=@Anteproyecto, Carta=@Carta, Dictamen=@Dictamen, Asignacion=@Asignacion, AsesorExt=@AsesorExt, Seguimiento=@Seguimiento, Registro=@Registro, CartaAgradecimiento=@CartaAgradecimiento, CDInforme=@CDInforme, CDRes=@CDRes, CartaAcep=@CartaAcep
	where Folio=@Folio
	end 

---MODIFICAR REGISTROS 
create proc modRegistros
@Matricula int, 
@Servicio bit, 
@Creditos bit, 
@Calificacion int, 
@Extra bit
as begin 
	update REQUISITOS set Servicio=@Servicio, Creditos=@Creditos, Calificacion=@Calificacion, Extra=@Extra
	where Matricula=@Matricula
	end

---MODIFICAR USUARIOS
create proc modUsuarios
@id int, 
@contraseña int, 
@tip varchar (30)
as begin 
	update Usuarios set contraseña=@contraseña, tipo=@tip
	where id=@id
	end

-------------------------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------

--ELIMINAR ALUMNOS
create proc elimAlumnos
@Matricula int 
as 
delete from Alumnos where Matricula=@Matricula

--ELIMINAR ASESORES
create proc elimAsesores
@ID int
as 
delete from Asesores where Id=@ID

--ELIMINAR CITAS
create proc elimCitas
@Clave int
as 
delete from Citas where Clave=@Clave

--ELIMINAR DOCUMENTACION
create proc elimDocumentacion
@Folio int
as 
delete from Documentacion where Folio=@Folio

--AGREGAR COLUMNA CALIFICACION A TABLA REQUISITOS
alter table REQUISITOS add Calificacion int

alter proc AgregarRequisistos
@Matricula int, 
@Servicio bit, 
@Creditos bit, 
@Calificacion int, 
@Extra bit
as
insert into REQUISITOS (Matricula, Servicio, Creditos, Calificacion, Extra) values ( @Matricula, @Servicio, @Creditos,@Calificacion, @Extra)

--ELIMINAR REQUISITOS
create proc elimRequisitos
@Matricula int
as delete from REQUISITOS where Matricula=@Matricula

--ELIMINAR USUARIOS
create proc elimUsuarios
@Usuario int
as delete from Usuarios where Usuario=@Usuario

--BITACORA DE ALUMNOS--
create table Bitscora_Alum
(
id_BitAl int identity primary key,
Telefono_nuevo varchar (10),
Telefono_viejo varchar (10),
Correo_nuevo varchar (50),
Correo_viejo varchar (50),
operacion varchar(10) not null,
usuario varchar(60) not null,
fecha datetime not null,
host varchar(50) not null
)
--BITACORA DE ASESORES--
create table Bitscora_Asesor
(
id_BitAs int identity primary key,
Telefono_nuevo varchar (10),
Telefono_viejo varchar (10),
Correo_nuevo varchar (50),
Correo_viejo varchar (50),
operacion varchar(10) not null,
usuario varchar(60) not null,
fecha datetime not null,
host varchar(50) not null
)

--BITACORA DE CITAS--
create table Bitscora_Cita
(
id_BitCita int identity primary key,
Hora_Nuevo DATETIME NOT NULL,
Hora_Viejo DATETIME NOT NULL,
operacion varchar(10) not null,
usuario varchar(60) not null,
fecha datetime not null,
host varchar(50) not null
)
--BITACORA DE USUARIO--
create table Bitscora_Usu
(
id_BitUsuario int identity primary key,
contraseña_Nuevo varchar (30),
contraseña_Viejo varchar (30),
operacion varchar(10) not null,
usuario varchar(60) not null,
fecha datetime not null,
host varchar(50) not null
)

--RELACION DE TABLA CITA-ALUMNOS--
alter table Citas add foreign key (Matricula) references Alumnos (Matricula)

--RELACION DE TABLA REQUISITOS-ALUMNOS--
alter table REQUISITOS add foreign key (Matricula) references Alumnos (Matricula)

--RELACION DE TABLA REQUISITOS-ALUMNOS--
alter table Citas add foreign key (Id) references Asesores (Id)
