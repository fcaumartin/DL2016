select *
from employe 
join dept on employe.nodep=dept.nodept
where employe.salaire>30000 and dept.nom='vente'

select *
from employe, dept 
where employe.nodep=dept.nodept 
and employe.salaire>30000 
and dept.nom='vente'

select employe.prenom, patron.prenom
from employe
join employe as patron on employe.nosup=patron.noemp


select salaire
from employe
where nom='amartakaldire'

select * 
from employe
where salaire > (select salaire
from employe
where nom='amartakaldire')


select *
from employe
join employe as amar on employe.salaire>amar.salaire
where amar.nom='amartakaldire'

select *
from employe
join employe as amar on amar.nom='amartakaldire'
where employe.salaire>amar.salaire


select *
from employe
join employe as amar 
on employe.salaire>amar.salaire and amar.nom='amartakaldire'

select *
from employe, employe as amar 
where employe.salaire>amar.salaire 
and amar.nom='amartakaldire'


--Rechercher le nom et le titre des employés du service 31 
--qui ont un
--titre que l'on trouve dans le département 32. 

select *
from employe
where nodep=31 and titre in (select titre
from employe
where nodep=32)

select *
from employe as dep31
join employe as dep32 on dep31.titre=dep32.titre
where dep31.nodep=31 and dep32.nodep=32


