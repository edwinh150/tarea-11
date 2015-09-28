create database Pelicula

go
use Pelicula
go

create table Categorias(
CategoriaId int primary key identity(1,1),Descripcion varchar(50));

select * from Categorias
