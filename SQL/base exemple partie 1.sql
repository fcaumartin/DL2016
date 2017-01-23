select nom 'nom l''employe'
from employe 


select distinct noemp, titre from employe


select * 
from employe
where salaire>40000 

select *
from employe
where nom<prenom 

select *
from Employe
where tItre = 'pRésiDent'



select *
from employe
where nom >= 'amartakaldire'
order by nom desc


select *
from employe
where tauxcom is not null


select nom, tauxcom, cast((tauxcom*salaire)/100 as int) as 'commission'
from employe
where ((tauxcom*salaire)/100)>1000
order by 2 asc


select prenom+cast(salaire as varchar(30))
from employe




select nom, SUBSTRING(nom, 1, 2), SUBSTRING(nom, -1, 2)
from employe

select nom, SUBSTRING(nom, 1, 2)
from employe


select nom, CHARINDEX('r', nom, 3)
from employe

select nom, CHARINDEX('r', SUBSTRING(nom, 3, LEN(nom)-2))
from employe
where CHARINDEX('r', SUBSTRING(nom, 3, LEN(nom)-2)) > 0



select nom
from employe
where nom like '__r%'

select nom, CHARINDEX('r', nom)
from employe
where CHARINDEX('r', nom) = 3


select nom, UPPER(SUBSTRING(nom, 1, 1)) + LOWER(SUBSTRING(nom, 2, LEN(nom)-1))
from employe

select nom, LEN(nom)
from employe















