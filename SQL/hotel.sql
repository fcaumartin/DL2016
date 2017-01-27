--Lot1

--Afficher la liste des h�tels. Le r�sultat doit faire appara�tre le nom de l�h�tel et la ville
select hot_nom, hot_ville from hotel

--Afficher la ville de r�sidence de Mr White Le r�sultat doit faire appara�tre le nom, 
-- le pr�nom, et l'adresse du client
select * from client where cli_nom='white'

--Afficher la liste des stations dont l�altitude < 1000 Le r�sultat doit faire appara�tre 
-- le nom de la station et l'altitude
select * from station where sta_altitude<1000

--Afficher la liste des chambres ayant une capacit� > 1 Le r�sultat doit faire appara�tre le num�ro de la chambre ainsi que la capacit�
select * from chambre where cha_capacite>1

--Afficher les clients n�habitant pas � Londre Le r�sultat doit faire appara�tre 
-- le nom du client et la ville
select * from client where cli_ville not in  ('Londre')

--Afficher la liste des h�tels situ�e sur la ville de Bretou et poss�dant une cat�gorie>3 Le r�sultat doit faire appara�tre le nom de l'h�tel, ville et la cat�gorie
select * from hotel where hot_ville='bretou' and hot_categorie>3

--Lot2

--Afficher la liste des h�tels avec leur station 
-- Le r�sultat doit faire appara�tre le nom de la station, le nom de l�h�tel, la cat�gorie, la ville)
select sta_nom, hot_nom, hot_categorie
from hotel
join station on sta_id=hot_sta_id

--Afficher la liste des chambres et leur h�tel Le r�sultat doit faire appara�tre le nom de l�h�tel, 
--la cat�gorie, la ville, le num�ro de la chambre)
select hot_nom, hot_categorie, hot_ville, cha_numero
from hotel
join chambre on hot_id=cha_hot_id


--Afficher la liste des chambres de plus d'une place dans des h�tels situ�s sur 
-- la ville de Bretou Le r�sultat doit faire appara�tre le nom de l�h�tel, la cat�gorie, la ville, le num�ro de la chambre et sa capacit�)
select hot_nom, hot_categorie, hot_ville, cha_numero, cha_capacite
from hotel
join chambre on hot_id=cha_hot_id
where hot_ville='bretou' and cha_capacite>=1

--Afficher la liste des r�servations avec le nom des clients Le r�sultat 
--doit faire appara�tre le nom du client, le nom de l�h�tel, la date de r�servation
select cli_nom, hot_nom, res_date
from hotel
join chambre on hot_id=cha_hot_id
join reservation on cha_id=res_cha_id
join client on cli_id=res_cli_id


--Afficher la liste des chambres avec le nom de l�h�tel et le nom de la station Le r�sultat doit faire appara�tre le nom de la station, le nom de l�h�tel, le num�ro de la chambre et sa capacit�)
select *
from chambre
join hotel on hot_id=cha_hot_id
join reservation on cha_id=res_cha_id
join station on sta_id=hot_sta_id


--Afficher les r�servations avec le nom du client et le nom de l�h�tel Le r�sultat doit faire appara�tre 
--le nom du client, le nom de l�h�tel, la date de d�but du s�jour et la dur�e du s�jour
select cli_nom, hot_nom, res_date_debut, DATEDIFF(day, res_date_debut, res_date_fin)
from client
join reservation on cli_id=res_cli_id
join chambre on cha_id=res_cha_id
join hotel on hot_id=cha_hot_id

--Lot3

--Compter le nombre d�h�tel par station
select sta_nom, count(*)
from station
join hotel on sta_id=hot_sta_id
group by sta_nom

--Compter le nombre de chambre par station
select sta_nom, count(*)
from station
join hotel on sta_id=hot_sta_id
join chambre on hot_id=cha_hot_id
group by sta_nom

--Compter le nombre de chambre par station ayant une capacit� > 1

select *
from station
join hotel on sta_id=hot_sta_id
join chambre on hot_id=cha_hot_id


select sta_nom, count(*)
from station
join hotel on sta_id=hot_sta_id
join chambre on hot_id=cha_hot_id
--where cha_capacite>1
group by sta_nom
having count(*)=3

--Afficher la liste des h�tels pour lesquels Mr Squire a effectu� une r�servation
select distinct hot_nom
from client
join reservation on cli_id=res_cli_id
join chambre on cha_id=res_cha_id
join hotel on hot_id=cha_hot_id
where cli_nom='squire'

--Afficher la dur�e moyenne des r�servations par station
select sta_nom,  AVG(DATEDIFF(day, res_date_debut, res_date_fin))
from chambre
join hotel on hot_id=cha_hot_id
join reservation on cha_id=res_cha_id
join station on sta_id=hot_sta_id
group by sta_nom