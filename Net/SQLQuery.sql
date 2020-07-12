create database parcial1
use Parcial1
create table alumno(
	ci int primary key,
	nombre varchar(20),
	paterno varchar(20),
	materno varchar(20),
	telefono varchar(10)
)
insert into alumno(ci, nombre, paterno, materno, telefono) values (9064877, 'Richard', 'Orihuela', 'Gil', '67142884')
select * from alumno