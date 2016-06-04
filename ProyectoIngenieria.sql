CREATE DATABASE Proyecto

use proyecto
CREATE TABLE Alumnos(
Matricula varchar(10) PRIMARY KEY NOT NULL,
Nombre VARCHAR(30) NOT NULL,
ApP VARCHAR (30) NOT NULL,
ApM VARCHAR (30) NOT NULL,
Carrera VARCHAR(20) NOT NULL,
Telefono VARCHAR(10),
Correo VARCHAR(100),
NombreProyecto VARCHAR(80),
Empresa VARCHAR(30))

CREATE TABLE Asesores(
Id INT IDENTITY (000,1) PRIMARY KEY NOT NULL,
Profesion VARCHAR(30),
Nombre VARCHAR(30) NOT NULL,
ApP VARCHAR (30) NOT NULL,
ApM VARCHAR(30) NOT NULL,
Tipo VARCHAR(20) NOT NULL,
Telefono VARCHAR (10),
Correo VARCHAR(50)
)

CREATE TABLE Citas(
Clave INT IDENTITY (1000,1) PRIMARY KEY,
Matricula varchar(10) NOT NULL,
Id INT NOT NULL,
Fecha DATETIME NOT NULL)



CREATE TABLE Documentacion(
Folio INT IDENTITY (2000,1) PRIMARY KEY,
matricula varchar(10),
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


create TABLE REQUISITOS(
ClveRequisitos int identity primary key,
Matricula INT NOT NULL,
Servicio BIT,
Creditos BIT,
Extra BIT,
calificaciones int,
fecha datetime
)



--CREACION TABLA USUARIOS
create table Usuarios(
id int primary key identity,
usuario varchar(30),
contraseña varchar (30),
tipo varchar (30))
<<<<<<< HEAD


=======
create procedure AgregaUsusario
@usuario varchar (30),
@contraseña varchar (30),
@tipo varchar (20)
as 
insert into Usuarios (usuario, contraseña, tipo) values (@usuario, @contraseña, @tipo)

--AGREGAR ALUMNOS
create proc AgregarAlumnos
@Matricula varchar(10),
@Nombre varchar (30),
@ApP varchar (30),
@ApM varchar (30),
@Carrera varchar (20),
@Telefono varchar (10),
@Correo varchar (100),
@NombreProyecto varchar (80),
@Empresa varchar (30)
as 
insert into Alumnos (Matricula, Nombre, ApP, ApM, Carrera, Telefono, Correo, NombreProyecto, Empresa) values (@Matricula,@Nombre, @ApP, @ApM, @Carrera, @Telefono, @Correo, @NombreProyecto, @Empresa)

--AGREGAR ASESORES

create proc AgregarAsesores
@Nombre varchar (30),
@ApP varchar (30),
@ApM varchar (30),
@Tipo varchar (20),
@Telefono varchar (10),
@Correo varchar (100),
@Profesion varchar (30)
as
begin
insert into Asesores (Nombre, ApP, ApM, Tipo, Telefono, Correo, Profesion) values ( @Nombre, @ApP, @ApM, @Tipo, @Telefono, @Correo, @Profesion)
end

--AGREGAR CITAS
create proc AgregarCitas
@Matricula varchar(10),
@Id int,
@Fecha datetime
as 
<<<<<<< HEAD
insert into Citas (Clave, Matricula, Id,Fecha) values (@Clave, @Matricula, @Id, @Fecha)
=======
insert into Citas (Matricula, Id,Hora) values (@Matricula, @Id, @Hora)
>>>>>>> origin/master

--AGREGAR DOCUMENTACION
create proc AgregarDocumentacion
@matricula varchar(10),
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
insert into Documentacion (Solicitud, Anteproyecto, Carta, Dictamen, Asignacion, AsesorExt, Seguimiento, Registro, CartaAgradecimiento, CDInforme, CDRes, CartaAcep) values (@Solicitud, @Anteproyecto, @Carta, @Dictamen, @Asignacion, @AsesorExt, @Seguimiento, @Registro, @CartaAgradecimiento, @CDInforme, @CDRes, @CartaAcep)

--AGREAGAR REQUISITOS

create proc AgregarRequisistos
@Matricula varchar(10), 
@Servicio bit, 
@Creditos bit,
@Calificacion int,
@Extra bit,
@fecha datetime
as
begin
insert into REQUISITOS (Matricula, Servicio, Creditos, calificaciones, Extra,fecha) values ( @Matricula, @Servicio, @Creditos, @Calificacion, @Extra,@fecha)
end


--AGREGAR USUARIO
create proc AgregarUsuario
@usuario int, 
@contraseña varchar (30),
@tipo varchar (30)
as 
insert into Usuarios (usuario, contraseña, tipo) values (@usuario, @contraseña, @tipo) 

------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------

--MODIFICAR ALUMNOS
create proc modAlumnos
@Matricula Varchar(10),
@Nombre varchar (30),
@ApP varchar (30),
@ApM varchar (30),
@Carrera varchar (20),
@Telefono varchar (10),
@Correo varchar (100),
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
@Correo varchar (100),
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
	update Citas set Matricula=@Matricula, Id=@Id, fecha=@Hora
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
@Matricula varchar(10), 
@Servicio bit, 
@Creditos bit, 
@Extra bit
as begin 
	update REQUISITOS set Servicio=@Servicio, Creditos=@Creditos, Extra=@Extra
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
Correo_nuevo varchar (100),
Correo_viejo varchar (100),
operacion varchar(10) not null,
usuario varchar(60) not null,
fecha datetime not null,
host varchar(50) not null
)

--------------------------------------------------------------------
--BITACORA DE ASESORES--
create table Bitscora_Asesor
(
id_BitAs int identity primary key,
Telefono_nuevo varchar (10),
Telefono_viejo varchar (10),
Correo_nuevo varchar (100),
Correo_viejo varchar (100),
operacion varchar(10) not null,
usuario varchar(60) not null,
fecha datetime not null,
host varchar(50) not null
)
---------------------------------------------------------------------

--BITACORA DE CITAS--
create table Bitscora_Cita
(
id_BitCita int identity primary key,
Hora_Nuevo DATETIME,
Hora_Viejo DATETIME,
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

--RELACION DE TABLA CITA-ALUMNOS--
alter table Citas add foreign key (Id) references Asesores (Id)

--RELACION DE TABLA DOCUMENTACION-ALUMNOS--
alter table Documentacion add foreign key (matricula) references Alumnos (Matricula)

--RELACION DE TABLA USUARIOS-ASESORES--
alter table Usuarios add foreign key(id) references Asesores(Id)

--TRIGGER PARA TABLA ALUMNOS INSERTAR--
create trigger InsertarAlum
on Alumnos
after insert
as
begin 
	declare @Telefono_nuevo varchar(10),@Telefono_viejo varchar (10),@Correo_nuevo varchar (50),@Correo_viejo varchar (50)
	select @Telefono_nuevo=Telefono,@Telefono_viejo= null,@Correo_nuevo=Correo,@Correo_viejo=null
	from inserted
	
	insert into Bitscora_Alum values(@Telefono_nuevo,@Telefono_viejo,@Correo_nuevo,@Correo_viejo,'INSERTADO',suser_name(),getdate(),@@servername) 
	end

--TRIGGER PARA TABLA ALUMNOS ELIMINAR--
create trigger EliminarAlum
on Alumnos
after delete
as
begin
	declare @Telefono_nuevo varchar(10),@Telefono_viejo varchar (10),@Correo_nuevo varchar (50),@Correo_viejo varchar (50)
	select @Telefono_nuevo=Telefono,@Telefono_viejo= null,@Correo_nuevo=Correo,@Correo_viejo=null
	from deleted
 
 	insert into Bitscora_Alum values(@Telefono_nuevo,@Telefono_viejo,@Correo_nuevo,@Correo_viejo,'ELIMINADO',suser_name(),getdate(),@@servername) 

end


--TRIGGER PARA TABLA ALUMNOS ACTUALIZAR--
create trigger ActualizarAlum
on Alumnos
for update 
as
begin 
	declare @Telefono_nuevo varchar(10),@Telefono_viejo varchar (10),@Correo_nuevo varchar (50),@Correo_viejo varchar (50)
	set @Telefono_nuevo=(select Telefono from inserted)
	set @Correo_nuevo =(select Correo from inserted)
	----
	set @Telefono_viejo =(select Telefono from deleted)
	set @Correo_viejo = (select Correo from deleted)
	
	insert into Bitscora_Alum values(@Telefono_nuevo,@Telefono_viejo,@Correo_nuevo,@Correo_viejo,'ACTUALIZADO',suser_name(),getdate(),@@servername) 

end


--TRIGGER PARA TABLA ASESORES INSERTAR--
create trigger InsertarAsesor
on Asesores
after insert
as
begin 
	declare @Telefono_nuevo varchar(10),@Telefono_viejo varchar (10),@Correo_nuevo varchar (50),@Correo_viejo varchar (50)
	select @Telefono_nuevo=Telefono,@Telefono_viejo= null,@Correo_nuevo=Correo,@Correo_viejo=null
	from inserted
	
	insert into Bitscora_Asesor values(@Telefono_nuevo,@Telefono_viejo,@Correo_nuevo,@Correo_viejo,'INSERTADO',suser_name(),getdate(),@@servername) 
	end
	
--TRIGGER PARA TABLA ASESORES ELIMINAR--
create trigger EliminarAsesor
on Asesores
after delete
as
begin
	declare @Telefono_nuevo varchar(10),@Telefono_viejo varchar (10),@Correo_nuevo varchar (50),@Correo_viejo varchar (50)
	select @Telefono_nuevo=Telefono,@Telefono_viejo= null,@Correo_nuevo=Correo,@Correo_viejo=null
	from deleted
 
 	insert into Bitscora_Asesor values(@Telefono_nuevo,@Telefono_viejo,@Correo_nuevo,@Correo_viejo,'ELIMINADO',suser_name(),getdate(),@@servername) 

end

--TRIGGER PARA TABLA ASESORES ACTUALIZAR--
create trigger ActualizarAsesor
on Asesores
for update 
as
begin 
	declare @Telefono_nuevo varchar(10),@Telefono_viejo varchar (10),@Correo_nuevo varchar (50),@Correo_viejo varchar (50)
	set @Telefono_nuevo=(select Telefono from inserted)
	set @Correo_nuevo =(select Correo from inserted)
	----
	set @Telefono_viejo =(select Telefono from deleted)
	set @Correo_viejo = (select Correo from deleted)
	
	insert into Bitscora_Asesor values(@Telefono_nuevo,@Telefono_viejo,@Correo_nuevo,@Correo_viejo,'ACTUALIZADO',suser_name(),getdate(),@@servername) 

end

---------------------------------------------------------------------------------------------------------
--TRIGGER PARA TABLA CITAS INSERTAR--
create trigger InsertarCita
on Citas
after insert
as
begin 
	declare Hora_Nuevo DATETIME, Hora_Viejo DATETIME
	select @Hora_Nuevo=Fecha,@Hora_Viejo= null
	from inserted
	
	insert into Bitscora_Cita values(@Hora_Nuevo,@Hora_Viejo,'INSERTADO',suser_name(),getdate(),@@servername) 
	end
--------------------------------------------------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------
--TRIGGER PARA TABLA CITAS ELIMINAR--
create trigger EliminarCita
on Citas
after delete
as
begin
	declare Hora_Nuevo Datetime, Hora_Viejo DATETIME
	select @Hora_Nuevo=Fecha,@Hora_Viejo= null
	from deleted
 
 	insert into Bitscora_Cita values(@Hora_Nuevo,@Hora_Viejo,'ELIMINADO',suser_name(),getdate(),@@servername) 

end
-------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------
--TRIGGER PARA TABLA CITAS ACTUALIZAR--
create trigger ActualizarCita
on Citas
for update 
as
begin 
	declare Hora_Nuevo DATETIME ,Hora_Viejo DATETIME
	set @Hora_Nuevo=(select Hora from inserted)
	----
	set Hora_Viejo =(select Hora from deleted)
	
	insert into Bitscora_Cita values(@Hora_Nuevo,Hora_Viejo,'ACTUALIZADO',suser_name(),getdate(),@@servername) 

end
--------------------------------------------------------------------------------------------------------------------

--------------------------------------------------------------------------------------------------------------------------
--TRIGGER PARA TABLA USUARIOS INSERTAR--
create trigger InsertarUsu
on Citas
after insert
as
begin 
	declare contraseña_Nuevo varchar(30), contraseña_Viejo varchar (30),
	select @contraseña_Nuevo=contraseña ,@contraseña_Viejo= null
	from inserted
	
	insert into Bitscora_Usu values(@contraseña_Nuevo,@contraseña_Viejo,'INSERTADO',suser_name(),getdate(),@@servername) 
	end
-----------------------------------------------------------------------------------------------------------------------------

--TRIGGER PARA TABLA USUARIOS ELIMINAR--
create trigger EliminarUsu
on Citas
after delete
as
begin
	declare contraseña_Nuevo varchar (30),contraseña_Viejo varchar (30),
	select @contraseña_Nuevo=contraseña ,@contraseña_Viejo= null
	from deleted
 
 	insert into Bitscora_Usu values(@contraseña_Nuevo,@contraseña_Viejo,'ELIMINADO',suser_name(),getdate(),@@servername) 

end

-----------------------------------------------------------------------------------------------------------------------
--TRIGGER PARA TABLA USUARIOS ACTUALIZAR--
create trigger ActualizarUsu
on Citas
for update 
as
begin 
	declare contraseña_Nuevo varchar (30),contraseña_Viejo varchar (30),
	set @contraseña_Nuevo=(select contraseña  from inserted)
	----
	set @contraseña_Viejo =(select contraseña  from deleted)
	
	insert into Bitscora_Usu values(@contraseña_Nuevo,@contraseña_Viejo,'ACTUALIZADO',suser_name(),getdate(),@@servername) 

end
--------------------------------------------------------------------------------------------------------------------------
>>>>>>> origin/master

select * from asesores