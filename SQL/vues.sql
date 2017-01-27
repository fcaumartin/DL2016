create view toto
as
select distinct p.libart, f.nomfou
from Fournisseur as f
join vente as v on v.numfou=f.numfou
join Produit as p on p.codart=v.codart
where p.stkphy < p.stkale*1.5 and v.delliv<=30






select * from toto where Produit.stkphy>100
go
drop view commandes
go
create view commandes
as
select f.*, p.*, e.datcom, e.obscom, l.derliv, l.numlig, l.priuni, l.qtecde, l.qteliv
from Fournisseur as f
join entcom as e on e.numfou=f.numfou
join ligcom l on l.numcom=e.numcom
join Produit as p on p.codart=l.codart



create view titi
as
select * 
from  commandes
where numfou=0120