Create table Tb_Comentario
(
 	Id_Comentario int identity(1,1) primary key, 
 	Id_Professor int,
 	Id_Aluno int,
 	Comentario varchar(500),
	Dia_Comentario date,
	Horario_Comentario time,
	Avaliacao decimal(3,2),
	Nome_Aluno varchar(80),
	Img_Perfil varchar(max)
);
use Studify
drop table Tb_Comentario
select * from Tb_Comentario