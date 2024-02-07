drop database if exists gokstadtur;
create database gokstadtur;
use gokstadtur;

drop table if exists Medlem;
create table Medlem (
	MNr int auto_increment,
    Fornavn varchar(15) not null,
    Etternavn varchar(15) not null,
    Tlf varchar(15) not null,
    primary key (MNr)
);

drop table if exists Hytte;
create table Hytte (
	HNr int auto_increment,
    Navn varchar(30) not null,
    AntSenger int not null,
    HytteType enum ('Betjent', 'Selvbetjent', 'Ubetjent'),
    primary key(HNr)
);

drop table if exists Tur;
create table Tur (
	TNr int auto_increment,
    Beskrivelse varchar(200) not null,
    Pris decimal(10, 2) not null,
    StartDato date not null,
    StartHytte int not null,
    primary key (TNr),
    foreign key(StartHytte) references Hytte(HNr)
);

drop table if exists Påmelding;
create table Påmelding (
	TNr int not null,
    MNr int not null,
    primary key(TNr, MNr),
    foreign key(TNr) references Tur(TNr),
    foreign key(MNr) references Medlem(MNr)
);

insert into Medlem (Fornavn, Etternavn, Tlf)
values
	('Ola', 'Hansen', 12345678),
    ('Kari', 'Mo', 87654321),
    ('Anette', 'Lien', 12341234),
    ('Johan', 'Åsen', 87658765);

insert into Hytte (Navn, AntSenger, HytteType)
values
	('Furubu', 25, 'Betjent'),
    ('Blåbergstua', 40, 'Selvbetjent'),
    ('Steinbua', 10, 'Ubetjent');

insert into Tur (Beskrivelse, Pris, StartDato, StartHytte)
values
	('Krevende topptur', 7500.00, '2022-04-22', 2),
	('Kort Familietur', 4200.00, '2022-07-15', 1),
	('Brevandring', 9400.00, '2022-08-02', 2),
	('Klassisk fjelltur', 6500.00, '2022-08-14', 1);

insert into Påmelding
values
	(3, 1),
	(4, 1),
	(1, 2),
	(4, 2),
	(1, 3),
	(2, 3),
	(4, 3);

/*
Oppgave 3.1
Skriv en SQL-spørring som viser turer som starter i juli og koster under 8000 kr.
Utskriften skal sorteres stigende etter pris. Hvis flere turer har samme pris,skal disse sorteres etter startdato.
*/
select *
from Tur
where StartDato like '2022-07%' and Pris < 8000
order by Pris, StartDato;


-- Oppgave 3.2
-- Skriv en SQL-spørring som viser medlemsnummer og navn for alle medlemmer som er påmeldt en tur som starter fra hytte nummer 2

select distinct m.*
from Medlem m
inner join Påmelding p using (MNr)
inner join Tur t on t.TNr = p.TNr
where t.StartHytte = 2;

/*
Oppgave 3.3
Lag en spørring som viser antall påmeldte og inntekt til hver enkelt tur.
Utskriften skal vise turnummer, beskrivelsen av turen, startdato for turen, antall påmeldte og hva den den totale summen medlemmene må betale.
*/

select t.TNr, t.Beskrivelse, t.StartDato, count(*) 'Påmeldte', (Pris * count(*)) 'Total Pris'
from tur t
inner join Påmelding p using (TNr)
group by t.TNr, t.Beskrivelse, t.StartDato;


-- Oppgave 3.4
-- Skriv en SQL-spørring som viser navn på medlemmer som ikke er påmeldt noen turer.

select *
from medlem
left join Påmelding p using (MNr)
where TNr is null;

/*
Oppgave 3.5
Skriv SQL-kode for å registrere et nytt medlem (f.eks Per Iversen) og melde vedkommende på tur nummer 3.
Tips: Funksjonen LAST_INSERT_ID tar ingen parametre og gir siste autonummererte primærnøkkelverdi som ble satt inn med INSERT.
*/
insert into Medlem (Fornavn, Etternavn, Tlf)
values ('Per', 'Iversen', 43214321);

insert into Påmelding (TNr, MNr)
values (3, last_insert_id());



-- Oppgave 4
drop procedure if exists RegistrerMedlem //
DELIMITER //

CREATE PROCEDURE RegistrerMedlem(
				in Fornavn varchar(30),
                in Etternavn varchar(30),
                in Tlf varchar(15),
                out MedlemsNummer int
)
BEGIN
	insert into Medlem (Fornavn, Etternavn, Tlf)
    values (Fornavn, Etternavn, Tlf);
    set MedlemsNummer = last_insert_id();
END //

DELIMITER ;

call RegistrerMedlem('Beate', 'Rasmussen', '65465465', @MedlemsNummer);

select MNr 'Medlemsnummer',
		Fornavn,
        Etternavn
from medlem
where MNr = @MedlemsNummer;


/*
 Oppgave 5
 
 Det som er uheldig med tabellen TurUtvidet er at den gjentar mye av dataen.
 det gjør databasen ganske inkonsistens, mye feil og unødvendig med lagringsplass.
 
 de funksjonelle avhengighetene denne tabellen har er:
	TNr -> Beskrivelse
    TNr -> Pris
    TNr + Dato -> Hytte

vi kan normalisere TurUtvidet tabellen, ved å dele den i 2 tabeller, Tur og Utvidet for eksempel

så har Tur tabellen PNr som primær nøkkel sammen med kolomnene Beskrivelse og Pris
Utvidet tabellen har PNr som både primær og fremmed nøkkel, Dato som primærNøkkel og kolonnen Hytte.
*/
 
 
 
