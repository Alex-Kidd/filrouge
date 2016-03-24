  --procédures stockées

--Chiffre d'affaire généré pour l'ensemble 

CREATE proc ChEns
as
select  sum (propri*qtecom) as chiffreAffaireEnsemble
from compose
join produit on produit.proid=compose.proid
 
 exec ChEns

--Chiffre d'affaire généré par fournisseur

drop proc ChFou

CREATE proc ChFou
 @fournisseur varchar(50)
as
select distinct produit.reffou, sum (propri*qtecom) as 'chiffre d''affaire fournisseur' 
from compose
join produit on produit.proid=compose.proid
where reffou= @fournisseur
group by produit.reffou

--exemple
exec ChFou
fender
--identique au dessus mais pas de variable fournis
create proc chiffre
as
select distinct produit.reffou, sum (propri*qtecom) as 'chiffreAffaireFournis' 
from compose
join produit on produit.proid=compose.proid
group by produit.reffou
 exec chiffre
---------------------------------

create proc CAcli
@fournisseur varchar(50)
as
select distinct produit.reffou, sum (propri*qtecom) as 'chiffre d''affaire fournisseur' from compose
join produit on produit.proid=compose.proid
where reffou= @fournisseur
group by produit.reffou

exec CAcli
schertler


--Liste des produits commandés (ref produit, qte commandé)

create proc totqtecom
as
select produit.proid, prolib, qtecom
from produit 
join compose on compose.proid=produit.proid

exec totqtecom

--Liste des commandes pour un client (date, ref client, montant)


create proc liscom
@client varchar (50)
as
select comdat as 'date de commande', com.cliref as 'reference client', cli.clinom as 'nom du client',compri as 'prix de la commande' from commande as com
join client as cli on cli.cliref=com.cliref
where clinom = @client

exec liscom 'jipih'


--Répartition du chiffre d'affaire par type de client 

create proc CAcli
@type bit 
as
select sum (compri) as 'chiffre d''affaire par type de client' from commande  as com
join client as cli on cli.cliref=com.cliref
where clistat=@type


exec CAcli
fender

--Lister les commandes en cours de livraison. 

create proc comEnCours
as
select * from commande where cometa like ('facturée') or cometa like ('en préparation') or cometa like ('saisie')

exec comEnCours
