insert into Tb_Aluno(Nome_Aluno, Foto_Aluno, Sexo_Aluno, Email_Aluno, Senha_Aluno, Contato1_Aluno, Contato2_Aluno, RG_Aluno, DataNascimento_Aluno, CEP_Aluno, Endereco_Aluno, NumeroEnd_Aluno, ComplementoEnd_Aluno, Bairro_Aluno, Cidade_Aluno, Estado_Aluno, Nome_Responsavel, Sexo_Responsavel, Email_Responsavel, Contato_Responsavel, CPF_Responsavel, RG_Responsavel,Categoria) values('Tiago Melo', 'upload/aluno/man-16.png', 'Masculino','tiago@gmail.com','123','(66) 5085-6092','(66) 9684-2167','16.984.713-5','23/11/2002','78735-014','Rua A-122', '990','','Residencial Sagrada Família','Rondonópolis','MT','Isabelle Araujo','Feminino','isa@gmail.com','(31) 8138-4618','557.257.940-83','42.539.530-3', 2)

insert into Tb_Aluno(Nome_Aluno, Foto_Aluno, Sexo_Aluno, Email_Aluno, Senha_Aluno, Contato1_Aluno, Contato2_Aluno, RG_Aluno, DataNascimento_Aluno, CEP_Aluno, Endereco_Aluno, NumeroEnd_Aluno, ComplementoEnd_Aluno, Bairro_Aluno, Cidade_Aluno, Estado_Aluno, Nome_Responsavel, Sexo_Responsavel, Email_Responsavel, Contato_Responsavel, CPF_Responsavel, RG_Responsavel,Categoria) values('Manuela Castro', 'upload/aluno/woman-7.png', 'Feminino','manuela@gmail.com','123','(77) 6382-8085','','42.539.530-3','31/08/1998','47807-730','Rua Marechal Rondon', '21','','Vila Soldados','Barreiras','BA','José Martins','Masculino','jose@gmail.com','(62) 8802-2302','679.721.950-72','34.975.535-8', 2)

select * from Tb_Aluno

--DELETANDO
delete from Tb_Aluno;

--RESENTANDO IDENTITY
DBCC CHECKIDENT ('Tb_Aluno', RESEED, 0);