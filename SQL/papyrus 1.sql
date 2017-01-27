--1. Quelles sont les commandes du fournisseur 09120 ?
select * 
from entcom
where numfou=9120

--2. Afficher le code des fournisseurs pour lesquels des commandes ont �t� pass�es.
select distinct numfou
from entcom

--3. Afficher le nombre de commandes fournisseurs pass�es, et le nombre de
--fournisseur concern�s.
select count(*), count(distinct numfou)
from entcom

--4. Editer les produits ayant un stock inf�rieur ou �gal au stock d'alerte et dont la
--quantit� annuelle est inf�rieur  � 1000
--(informations � fournir : n� produit, libell� produit, stock, stock actuel d'alerte,
--quantit� annuelle)
select *
from produit
where stkphy<=stkale and qteann<1000

--5. Quels sont les fournisseurs situ�s dans les d�partements 75 78 92 77 ?
--L�affichage (d�partement, nom fournisseur) sera effectu� par d�partement
--d�croissant, puis par ordre alphab�tique
select *
from fournisseur
--where SUBSTRING(posfou, 1, 2) in (75, 78, 92 ,77)
where posfou like '75%' or posfou like '78%'

--6. Quelles sont les commandes pass�es au mois de mars et avril ?
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




--7. Quelles sont les commandes du jour qui ont des observations particuli�res ?
--(Affichage num�ro de commande, date de commande)
select *
from entcom
where 
day(datcom)=day(GETDATE()) 
and month(datcom)=month(GETDATE()) 
and year(datcom)=year(GETDATE())
-- DATEDIFF(day, datcom, GETDATE())=0
and obscom is not null







--8. Lister le total de chaque commande par total d�croissant
--(Affichage num�ro de commande et total)
select numcom, sum(cast(priuni as money)*qtecde) as 'somme'
from ligcom
group by numcom 
order by 'somme' desc, 1 asc


--9. Lister les commandes dont le total est sup�rieur � 10 000� ;
--on exclura dans le
--calcul du total les articles command�s en quantit� sup�rieure 
--ou �gale � 1000.
--(Affichage num�ro de commande et total)
select numcom, sum(cast(priuni as money)*qtecde) as 'somme'
from ligcom
where qtecde>=1000
group by numcom 
having sum(cast(priuni as money)*qtecde)>1000000








--10.Lister les commandes par nom fournisseur
--(Afficher le nom du fournisseur, le num�ro de commande et la date)
select f.nomfou, e.numcom, e.datcom
from entcom as e
join Fournisseur as f on f.numfou=e.numfou



--11.Sortir les produits des commandes 
-- ayant le mot "urgent' en observation?
-- (Afficher le num�ro de commande, le nom du fournisseur, 
-- le libell� du produit et
-- le sous total = quantit� command�e * Prix unitaire)
create index idx1 on entcom(obscom)

select *
from entcom
--where obscom like '%urgent%'
where contains(obscom, 'urgent')