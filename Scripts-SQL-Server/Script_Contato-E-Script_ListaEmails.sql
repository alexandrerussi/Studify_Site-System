use Studify

select * from TbContato;
select * from Tb_ListaEmails;

create table TbContato(
	id int primary key identity(1,1),
	nome varchar(50),
	email varchar(50),
	mensagem varchar(200),
	vitrine varchar(3)
)


create table Tb_ListaEmails(
	id int primary key identity(1,1),
	Email varchar(50)
)