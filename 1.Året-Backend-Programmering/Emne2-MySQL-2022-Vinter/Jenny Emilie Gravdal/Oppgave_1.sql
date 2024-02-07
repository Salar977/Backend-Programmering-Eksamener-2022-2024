create database gokstadtur;

create table if not exists `Medlem`(
MNr int auto_increment, primary key(MNr),
Fornavn varchar(50) not null,
Etternavn varchar(100) not null,
Tlf int
);

create table if not exists `Hytte`(
HNr int auto_increment, primary key(HNr),
Navn varchar(25) not null, 
AntSenger tinyint not null, 
HytteType char(13) not null
);

create table if not exists `Tur`(
 TNr int auto_increment, primary key(TNr),
 Beskrivelse varchar(50),
 pris decimal(8, 2),
 StartDato date,
 StartHytte int 
); 

Alter table Tur
Add FOREIGN KEY (StartHytte) references Hytte(HNr);

create table if not exists `Påmelding`(
 TNr int,
 MNr int, 
 primary key (TNr, MNr),
 Foreign key (TNr) references Tur(TNr),
 Foreign key (MNr) references Medlem(MNr)
);

insert into Medlem(Fornavn, Etternavn, Tlf)
values ('Ola', 'Hansen', '12345678'),
	   ('Kari', 'Mo', '87654321'),
       ('Anette', 'Lien', '12341234'),
       ('Johan', 'Åsen', '87658765');
       
insert into Hytte(Navn, AntSenger, HytteType)
values ('Furubu', '25', 'Betjent'),
       ('Blåbergstua', '40', 'Selvbetjent'),
       ('Steinbua', '10', 'Ubetjent');
       
insert into Tur(Beskrivelse, pris, StartDato, StartHytte)
values ('Krevende topptur', '7500.00', '2022-04-22', '2'),
       ('Kort familietur', '4200.00', '2022-07-15', '1'),
       ('Brevandring', '9400.00', '2022-08-02', '2'),
       ('Klassisk fjelltur', '6500.00', '2022-08-14', '1');
       
insert into Påmelding(TNr, MNr)
values ('3', '1'),
       ('4', '1'),
       ('1', '2'),
       ('4', '2'),
       ('1', '3'),
       ('2', '3'),
       ('4', '3');


