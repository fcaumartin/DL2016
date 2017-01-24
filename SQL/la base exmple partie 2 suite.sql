select * from employe

select * from dept

--1. Rechercher le pr�nom des employ�s et le num�ro de la r�gion de leur
--d�partement. 
select prenom, noregion
from employe
inner join dept on nodept=nodep

select prenom, noregion
from employe, dept
where nodept=nodep


--2. Rechercher le num�ro du d�partement, le nom du d�partement, le
--nom des employ�s class�s par num�ro de d�partement (renommer les
--tables utilis�es). 

select e.nodep, d.nom, e.nom
from employe as e
join dept as d on e.nodep=d.nodept
order by d.nodept


--3. Rechercher le nom de l'employ� Amartakaldire et le nom de son
--d�partement, ne pas utiliser de crit�re de jointure (volontairement). 

select employe.nom, dept.nom
from employe, dept
where employe.nom='amartakaldire' and employe.nodep=dept.nodept

select employe.nom, dept.nom
from employe
join dept on employe.nodep=dept.nodept
where employe.nom='amartakaldire'


--4. Rechercher le nom des employ�s du d�partement Distribution. 

select employe.nom, dept.nom
from employe
join dept on employe.nodep=dept.nodept
where dept.nom='distribution'


--5. Rechercher le nom et le salaire des employ�s qui gagnent plus que
--leur patron, et le nom et le salaire de leur patron. 
select employe.prenom, employe.salaire, patron.prenom, patron.salaire
from employe
join employe as patron on employe.nosup=patron.noemp
where employe.salaire>patron.salaire



--6. Rechercher le nom et le salaire des employ�s qui gagnent plus que
--Amartakaldire, le nom et le salaire de Amartakaldire. 

select employe.nom, employe.salaire, amar.salaire
from employe as amar 
join employe on employe.salaire>amar.salaire
where amar.nom='amartakaldire'


--7. Rechercher le nom et le titre des employ�s qui ont le m�me titre que
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



--8. Rechercher le nom et le titre des employ�s du service 31 qui ont un
--titre que l'on trouve dans le d�partement 32.

select dep31.*
from employe as dep32
join employe dep31 on dep31.titre=dep32.titre
where dep32.nodep=32 and dep31.nodep=31

--9. Rechercher le nom, le titre et le salaire des employ�s qui ont le m�me
--titre et le m�me salaire que Fairent. 

select *
from employe as fairent
join employe on employe.titre=fairent.titre and employe.salaire=fairent.salaire
where fairent.nom='fairent' 


select employe.*
from employe as fairent, employe 
where fairent.nom='fairent' 
and employe.titre=fairent.titre 
and employe.salaire=fairent.salaire




--10.Rechercher le nom et le titre des employ�s qui ont le m�me titre que
--Amartakaldire. 

select * from employe where titre=(
select titre from employe where nom='amartakaldire')

--I Rechercher le nom, le salaire et le num�ro de d�partement
--des employ�s qui gagnent plus qu'un seul employ� du d�partement 31,
--class�s par num�ro de d�partement et salaire.

select * from employe where salaire > ANY (
select salaire from employe where nodep=31)


--II Rechercher le nom, le salaire et le num�ro de d�partement
--des employ�s qui gagnent plus que tous les employ�s du d�partement
--31, class�s par num�ro de d�partement et salaire. 

select * from employe where salaire > ALL (
select salaire from employe where nodep=31)


--13.Rechercher le nom et le titre des employ�s du service 31 qui ont un
--titre que l'on trouve dans le d�partement 32. 

select * from employe where titre IN (
select titre from employe where nodep=32) and nodep=31


--14.Rechercher le nom et le titre des employ�s du service 31 qui ont un
--titre l'on ne trouve pas dans le d�partement 32.

select * from employe where titre != (
select titre from employe where nodep=32)

--15.Rechercher le nom, le titre et le salaire des employ�s qui ont le m�me
--titre et le m�me salaire que Fairant. 

select * from employe 
where salaire=(select salaire from employe where nom='fairent')
and titre=(select titre from employe where nom='fairent')

--select * from employe 
--where (salaire, titre)=(select salaire, titre from employe where nom='fairent')

select * from employe where nodep IN (
select nodept from dept where noregion=1)



--16.Rechercher le num�ro de d�partement, le nom et le salaire des employ�s qui
--gagnent plus que la moyenne de leur d�partement, class�s par d�partement

select * from employe as e1 where e1.salaire>(
select AVG(e2.salaire) from employe as e2 where e2.nodep=e1.nodep)


--17.Rechercher le num�ro d'employ�, le nom, le pr�nom des employ�s pour
--lesquel il existe au moins un Repr�sentant dans leur d�partement. 

select * from employe as e1
where exists (
		select * from employe as e2 
		where e1.nodep=e2.nodep and e2.titre='representant'
		)

select * from employe where nodep in (
select nodep from employe where titre='representant')



--18.Rechercher le num�ro de d�partement, le nom du d�partement dans lesquels
--il n'y a personne et montrer que le d�partement ne contient pas d'employ�. 

select * from dept where not exists (
	select * from employe where nodep=nodept
)

select * from dept where nodept not in (
select nodep from employe)


--19.Rechercher le num�ro de d�partement, le nom du d�partement, le
--nom des employ�s, en affichant aussi les d�partements dans lesquels
--il n'y a personne, class�s par num�ro de d�partement. 



select * 
from employe 
full join dept on employe.nodep=dept.nodept
