Create table Agenda
(
	Id_Agenda int identity(1,1) primary key,
	Id_Professor int not null,
	Dia varchar(200) not null,
	Manha varchar(200),
	Tarde varchar(200),
	Noite varchar(200)
);

drop table Agenda

use Studify