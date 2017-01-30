--1. Application d'une augmentation de tarif de 4% pour le 
--prix 1, 2% pour le prix2
--pour le fournisseur 9180
update vente
set prix1=prix1*1.04, prix2=prix2*1.02
where numfou=9180


--2. Dans la table vente, mettre à jour le prix2 
-- des articles dont le prix2 est null, en
--affectant le plus petit prix1 des fournisseurs susceptible 
-- de fournir cet article
select * from vente where prix2 is null

update vente
set prix2 = (select min(prix1) from vente as v where v.codart=vente.codart)
where prix2 is null


--3. Mettre à jour le champ obscom en positionnant '*****' 
--pour toutes les commandes
--dont le fournisseur a un indice de satisfaction <5
update entcom
set obscom='*****'
from entcom
join Fournisseur on Entcom.numfou=Fournisseur.numfou
where Fournisseur.satisf<5

update entcom
set obscom='*****'
where numfou in (select numfou from Fournisseur where satisf<5)




--4. Suppression du produit I110
delete 
from produit
where codart='I110'


delete from ligcom where codart='I110'
delete from vente where codart='I110'


--5. Suppression des entête de commande qui n'ont aucune ligne
delete from entcom
where numcom in (
	select numcom 
	from entcom
	where numcom not in (select numcom from ligcom)
)