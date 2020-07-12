create database alumno

create table estudiante(
	ci int primary key,
	nombre varchar(20),
	paterno varchar(20),
	materno varchar(20),
	telefono int
)
insert into estudiante(ci, nombre, paterno, materno, telefono) values (9064877, 'Richard', 'Orihuela', 'Gil', 67142884)
select * from estudiante