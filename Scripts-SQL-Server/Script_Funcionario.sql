use Studify

CREATE TABLE Tb_Funcionario(
	Id_Funcionario int IDENTITY(1,1) NOT NULL primary key,
	Nome_Funcionario varchar(80) NOT NULL,
	Foto_Funcionario varchar(max) NOT NULL,
	Sexo_Funcionario varchar(9) NOT NULL,
	Email_Funcionario varchar(100) unique NOT NULL,
	Telefone_Funcionario varchar(15) NOT NULL,
	Celular_Funcionario varchar(17) NOT NULL,
	CPF_Funcionario varchar(14) NOT NULL,
	RG_Funcionario varchar(12) NOT NULL,
	DataNascimento_Funcionario varchar(10) NOT NULL,
	CEP_Funcionario varchar(9) NOT NULL,
	Endereco_Funcionario varchar(50) NOT NULL,
	NumeroEnd_Funcionario varchar(10) NOT NULL,
	ComplementoEnd_Funcionario varchar(10),
	Bairro_Funcionario varchar(50) NOT NULL,
	Cidade_Funcionario varchar(50) NOT NULL,
	Estado_Funcionario varchar(50) NOT NULL,
	Cargo_Funcionario varchar(30) NOT NULL,
	Salario_Funcionario decimal(10,2) NOT NULL,
	Login_Funcionario varchar(50) unique NOT NULL,
	Senha_Funcionario varchar(50) NOT NULL,	
);

DBCC CHECKIDENT ('Tb_Funcionario', RESEED, 0);