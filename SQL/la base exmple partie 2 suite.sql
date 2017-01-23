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



