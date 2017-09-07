Create table Tb_Aluno
(
	--Cadastro Aluno
	Id_Aluno int primary key identity(1,1) not null,
	Nome_Aluno varchar(80) NOT NULL,
	Foto_Aluno varchar(max), -- Deixar NULL
	Sexo_Aluno varchar(9) NOT NULL,
	Email_Aluno varchar(100) NOT NULL, --Será utilizado para o login
	Senha_Aluno varchar(50) NOT NULL,
	Contato1_Aluno varchar(17) NOT NULL, --Pode ser um telefone ou um celular
	Contato2_Aluno varchar(17),
	RG_Aluno varchar(12) NOT NULL,
	DataNascimento_Aluno varchar(10) NOT NULL,
	CEP_Aluno varchar(9) NOT NULL,
	Endereco_Aluno varchar(50) NOT NULL,
	NumeroEnd_Aluno varchar(10) NOT NULL,
	ComplementoEnd_Aluno varchar(10),
	Bairro_Aluno varchar(50) NOT NULL,
	Cidade_Aluno varchar(50) NOT NULL,
	Estado_Aluno varchar(50) NOT NULL,
	--Skype_Aluno varchar(50),
	--Hangout_Aluno varchar(50),	
	--Sera necessário o contato de um responsavel, caso o aluno seja menor de 18 anos
	Nome_Responsavel varchar(80),
	Sexo_Responsavel varchar(9),
	Email_Responsavel varchar(100),
	Contato_Responsavel varchar(15),
	CPF_Responsavel varchar(14),
	RG_Responsavel varchar(12),	
	--Chave Estrangeira
	Id_Agenda01 int,
	Id_ComentarioAluno int,
	Categoria int
);

use Studify

select * from Tb_Aluno

delete from Tb_Aluno

drop table Tb_Aluno
DBCC CHECKIDENT ('Tb_Aluno', RESEED, 0);