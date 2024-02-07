# Oppgave 4

DELIMITER //
CREATE PROCEDURE RegistrerMedlem(IN p_fornavn varchar(50), IN p_etternavn varchar(100), IN p_tlf int, OUT Medlemsnummer int)
BEGIN
    
    insert into medlem (fornavn, etternavn, tlf)
    values (p_fornavn, p_etternavn, p_tlf);
    set Medlemsnummer = last_insert_Id();
    
END //
    
DELIMITER ;

#drop procedure if exists RegistrerMedlem;

call RegistrerMedlem('Beate', 'Rasmussen', '65465465', @Medlemsnummer);

select MNr 'Medlemsnummer', Fornavn, Etternavn
from medlem
where MNr = @Medlemsnummer;

