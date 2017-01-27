--Lot1

--Afficher la liste des hôtels. Le résultat doit faire apparaître le nom de l’hôtel et la ville
select hot_nom, hot_ville from hotel

--Afficher la ville de résidence de Mr White Le résultat doit faire apparaître le nom, 
-- le prénom, et l'adresse du client
select * from client where cli_nom='white'

--Afficher la liste des stations dont l’altitude < 1000 Le résultat doit faire apparaître 
-- le nom de la station et l'altitude
select * from station where sta_altitude<1000

--Afficher la liste des chambres ayant une capacité > 1 Le résultat doit faire apparaître le numéro de la chambre ainsi que la capacité
select * from chambre where cha_capacite>1

--Afficher les clients n’habitant pas à Londre Le résultat doit faire apparaître 
-- le nom du client et la ville
select * from client where cli_ville not in  ('Londre')

--Afficher la liste des hôtels située sur la ville de Bretou et possédant une catégorie>3 Le résultat doit faire apparaître le nom de l'hôtel, ville et la catégorie
select * from hotel where hot_ville='bretou' and hot_categorie>3

--Lot2

--Afficher la liste des hôtels avec leur station 
-- Le résultat doit faire apparaître le nom de la station, le nom de l’hôtel, la catégorie, la ville)
select sta_nom, hot_nom, hot_categorie
from hotel
join station on sta_id=hot_sta_id

--Afficher la liste des chambres et leur hôtel Le résultat doit faire apparaître le nom de l’hôtel, 
--la catégorie, la ville, le numéro de la chambre)
select hot_nom, hot_categorie, hot_ville, cha_numero
from hotel
join chambre on hot_id=cha_hot_id


--Afficher la liste des chambres de plus d'une place dans des hôtels situés sur 
-- la ville de Bretou Le résultat doit faire apparaître le nom de l’hôtel, la catégorie, la ville, le numéro de la chambre et sa capacité)
select hot_nom, hot_categorie, hot_ville, cha_numero, cha_capacite
from hotel
join chambre on hot_id=cha_hot_id
where hot_ville='bretou' and cha_capacite>=1

--Afficher la liste des réservations avec le nom des clients Le résultat 
--doit faire apparaître le nom du client, le nom de l’hôtel, la date de réservation
select cli_nom, hot_nom, res_date
from hotel
join chambre on hot_id=cha_hot_id
join reservation on cha_id=res_cha_id
join client on cli_id=res_cli_id


--Afficher la liste des chambres avec le nom de l’hôtel et le nom de la station Le résultat doit faire apparaître le nom de la station, le nom de l’hôtel, le numéro de la chambre et sa capacité)
select *
from chambre
join hotel on hot_id=cha_hot_id
join reservation on cha_id=res_cha_id
join station on sta_id=hot_sta_id


--Afficher les réservations avec le nom du client et le nom de l’hôtel Le résultat doit faire apparaître 
--le nom du client, le nom de l’hôtel, la date de début du séjour et la durée du séjour
select cli_nom, hot_nom, res_date_debut, DATEDIFF(day, res_date_debut, res_date_fin)
from client
join reservation on cli_id=res_cli_id
join chambre on cha_id=res_cha_id
join hotel on hot_id=cha_hot_id

--Lot3

--Compter le nombre d’hôtel par station
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

--Compter le nombre de chambre par station ayant une capacité > 1

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

--Afficher la liste des hôtels pour lesquels Mr Squire a effectué une réservation
select distinct hot_nom
from client
join reservation on cli_id=res_cli_id
join chambre on cha_id=res_cha_id
join hotel on hot_id=cha_hot_id
where cli_nom='squire'

--Afficher la durée moyenne des réservations par station
select sta_nom,  AVG(DATEDIFF(day, res_date_debut, res_date_fin))
from chambre
join hotel on hot_id=cha_hot_id
join reservation on cha_id=res_cha_id
join station on sta_id=hot_sta_id
group by sta_nom