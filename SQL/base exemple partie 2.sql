select *
from employe 
join dept on employe.nodep=dept.nodept
where employe.salaire>30000

select *
from employe, dept 
where (employe.nodep=dept.nodept) and (employe.salaire>30000)
