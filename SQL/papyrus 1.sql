--1. Quelles sont les commandes du fournisseur 09120 ?
select * 
from entcom
where numfou=9120

--2. Afficher le code des fournisseurs pour lesquels des commandes ont été passées.
select distinct numfou
from entcom

--3. Afficher le nombre de commandes fournisseurs passées, et le nombre de
--fournisseur concernés.
select count(*), count(distinct numfou)
from entcom

--4. Editer les produits ayant un stock inférieur ou égal au stock d'alerte et dont la
--quantité annuelle est inférieur  à 1000
--(informations à fournir : n° produit, libellé produit, stock, stock actuel d'alerte,
--quantité annuelle)
select *
from produit
where stkphy<=stkale and qteann<1000

--5. Quels sont les fournisseurs situés dans les départements 75 78 92 77 ?
--L’affichage (département, nom fournisseur) sera effectué par département
--décroissant, puis par ordre alphabétique
select *
from fournisseur
--where SUBSTRING(posfou, 1, 2) in (75, 78, 92 ,77)
where posfou like '75%' or posfou like '78%'

--6. Quelles sont les commandes passées au mois de mars et avril ?
select *
from entcom
where DATEPART(month, datcom) in (3,4)


select datcom, month(datcom), year(datcom), day(datcom), DATEPART(WEEKDAY ,datcom)
from entcom

SET DATEFORMAT dmy;
select DATEPART(ISO_WEEK, '10/01/2017')
SET DATEFORMAT mdy;
select DATEPART(WEEK, '10/01/2017')

select DATEADD(day, 20, '20/02/2016')




--7. Quelles sont les commandes du jour qui ont des observations particulières ?
--(Affichage numéro de commande, date de commande)
select *
from entcom
where 
day(datcom)=day(GETDATE()) 
and month(datcom)=month(GETDATE()) 
and year(datcom)=year(GETDATE())
-- DATEDIFF(day, datcom, GETDATE())=0
and obscom is not null







--8. Lister le total de chaque commande par total décroissant
--(Affichage numéro de commande et total)
select numcom, sum(cast(priuni as money)*qtecde) as 'somme'
from ligcom
group by numcom 
order by 'somme' desc, 1 asc


--9. Lister les commandes dont le total est supérieur à 10 000€ ;
--on exclura dans le
--calcul du total les articles commandés en quantité supérieure 
--ou égale à 1000.
--(Affichage numéro de commande et total)
select numcom, sum(cast(priuni as money)*qtecde) as 'somme'
from ligcom
where qtecde>=1000
group by numcom 
having sum(cast(priuni as money)*qtecde)>1000000








--10.Lister les commandes par nom fournisseur
--(Afficher le nom du fournisseur, le numéro de commande et la date)
select f.nomfou, e.numcom, e.datcom
from entcom as e
join Fournisseur as f on f.numfou=e.numfou



--11.Sortir les produits des commandes 
-- ayant le mot "urgent' en observation?
-- (Afficher le numéro de commande, le nom du fournisseur, 
-- le libellé du produit et
-- le sous total = quantité commandée * Prix unitaire)
create index idx1 on entcom(obscom)

select *
from entcom
--where obscom like '%urgent%'
where contains(obscom, 'urgent')