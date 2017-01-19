select nom as 'Employé', prenom, salaire, tauxcom as 'Commission' 
from employe
where salaire>30000 and salaire<40000




select *
from employe
where prenom like '[a-e]%'
order by titre desc





select prenom+nom
from employe
where nom+prenom='zeublouseagathe'










