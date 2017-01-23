select * from employe

select * from dept

--1. Rechercher le prénom des employés et le numéro de la région de leur
--département. 
select prenom, noregion
from employe
inner join dept on nodept=nodep

select prenom, noregion
from employe, dept
where nodept=nodep


--2. Rechercher le numéro du département, le nom du département, le
--nom des employés classés par numéro de département (renommer les
--tables utilisées). 

select e.nodep, d.nom, e.nom
from employe as e
join dept as d on e.nodep=d.nodept
order by d.nodept


--3. Rechercher le nom de l'employé Amartakaldire et le nom de son
--département, ne pas utiliser de critère de jointure (volontairement). 

select employe.nom, dept.nom
from employe, dept
where employe.nom='amartakaldire' and employe.nodep=dept.nodept

select employe.nom, dept.nom
from employe
join dept on employe.nodep=dept.nodept
where employe.nom='amartakaldire'


--4. Rechercher le nom des employés du département Distribution. 

select employe.nom, dept.nom
from employe
join dept on employe.nodep=dept.nodept
where dept.nom='distribution'


--5. Rechercher le nom et le salaire des employés qui gagnent plus que
--leur patron, et le nom et le salaire de leur patron. 
select employe.prenom, employe.salaire, patron.prenom, patron.salaire
from employe
join employe as patron on employe.nosup=patron.noemp
where employe.salaire>patron.salaire



--6. Rechercher le nom et le salaire des employés qui gagnent plus que
--Amartakaldire, le nom et le salaire de Amartakaldire. 

select employe.nom, employe.salaire, amar.salaire
from employe as amar 
join employe on employe.salaire>amar.salaire
where amar.nom='amartakaldire'


--7. Rechercher le nom et le titre des employés qui ont le même titre que
--Amartakaldire. 
select *
from employe as amar
join employe on employe.titre=amar.titre
where amar.nom='amartakaldire'

select *
from employe as amar
join employe on amar.nom='amartakaldire'
where employe.titre=amar.titre

select *
from employe as amar, employe
where employe.titre=amar.titre and amar.nom='amartakaldire'



