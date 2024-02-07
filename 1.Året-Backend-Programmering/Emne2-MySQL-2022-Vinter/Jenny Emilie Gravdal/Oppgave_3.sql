# 3.1 Skriv en SQL-spørring som viser turer som starter i juli og koster under 8000 kr. 
# Utskriften skal sorteres stigende etter pris. Hvis flere turer har samme pris,skal disse sorteres etterstartdato.
select Beskrivelse, pris, startdato 
from tur
where pris < 8000.00 and startdato between '2022-07-01' and '2022-07-31'
order by pris, startdato;

# 3.2 Skriv en SQL-spørring som viser medlemsnummer og navn for alle medlemmer som er påmeldt en tur som starter fra hytte nummer 2
select m.MNr, concat(m.fornavn, ' ', m.etternavn) as Navn
from Medlem m
inner join påmelding p
on m.MNr = p.MNr
inner join Tur t
on p.TNr = t.TNr
where starthytte = 2;

# 3.3 Lag en spørring som viser antall påmeldte og inntekt til hver enkelt tur. 
# Utskriften skal vise turnummer, beskrivelsen av turen, startdato for turen, antall påmeldte og hva den den totale summen medlemmene må betale.
Select Distinct p.Tnr, t.beskrivelse, t.startdato, count(p.MNr) as påmeldte, count(p.MNr) * t.pris as totalpris
from tur t
inner join påmelding p
on t.TNr = p.TNr
group by p.TNr
;

# 3.4 skriv en SQL-spørring som viser navn på medlemmer som ikke er påmeldt noen turer
select m.MNr, concat(m.fornavn, ' ', m.etternavn) as Navn
from medlem m
where not exists(select p.MNr from påmelding p where p.MNr = m.MNr);

# 3.5 Skriv SQL-kode for å registrere et nytt medlem (f.eks Per Iversen) og melde vedkommende på tur nummer 3.
insert into medlem(Fornavn, Etternavn, Tlf)
values ('Per', 'Iversen', '23452346');
insert into påmelding(TNr, MNr)
values('3', last_insert_id());

