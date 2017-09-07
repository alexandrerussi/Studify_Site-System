use Studify

CREATE TABLE Tb_Professor(
	--Cadastro Professor
	Id_Professor int primary key IDENTITY(1,1) NOT NULL,
	Nome_Professor varchar(80) NOT NULL,
	Foto_Professor varchar(max),
	Video_Professor varchar(max),
	Sexo_Professor varchar(9) NOT NULL,
	Email_Professor varchar(100) NOT NULL, --Será utilizado para fazer o Login
	Senha_Professor varchar(50) NOT NULL,
	Contato1_Professor varchar(17) NOT NULL,
	Contato2_Professor varchar(17),
	CPF_Professor varchar(14) NOT NULL,
	DataNascimento_Professor varchar(10) NOT NULL,
	CEP_Professor varchar(9) NOT NULL,
	Endereco_Professor varchar(80) NOT NULL,
	NumeroEnd_Professor varchar(10) NOT NULL,
	ComplementoEnd_Professor varchar(10),
	Bairro_Professor varchar(50) NOT NULL,
	Cidade_Professor varchar(50) NOT NULL,
	Estado_Professor varchar(50) NOT NULL,
	--Cadastro Aulas
	Segmento_Professor varchar(50) NOT NULL, --Ensino Médio / Ensino Técnico / ...
	Disciplina_Professor varchar(50) NOT NULL, --Matemática / Web / DB / ...
	HorarioAula_Professor varchar(50),
	Formacao_Professor varchar(50) NOT NULL,
	Valor_Aula_Professor decimal(10,2) NOT NULL,
	Descricao_Professor varchar(500),
	Avaliacao_Professor decimal(3,2),
	--Redes Sociais
	Skype_Professor varchar(50),
	Facebook_Professor varchar(200),
	Linkedin_Professor varchar(200),
	Youtube_Professor varchar(200),
	--Chave Estrangeira
	Id_Agenda int,
	Id_ComentarioProfessor int,
	Categoria int
);

select * from Tb_Professor

drop table Tb_Professor

DBCC CHECKIDENT ('Tb_Professor', RESEED, 0);