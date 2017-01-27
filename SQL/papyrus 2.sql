--12.Coder de 2 manières différentes la requête suivante :
--Lister le nom des fournisseurs susceptibles de livrer au moins un article

select nomfou from Fournisseur where numfou in (
	select numfou from entcom where numcom in (
		select numcom from Ligcom where qteliv<qtecde))

select f.nomfou
from Fournisseur as f
join entcom as e on f.numfou=e.numfou
join Ligcom as l on e.numcom=l.numcom
where l.qteliv<l.qtecde


--13.Coder de 2 manières différentes la requête suivante
--Lister les commandes (Numéro et date) dont le fournisseur est celui de la
--commande 70210 :

select numcom, datcom from entcom where numfou in (
	select numfou from entcom where numcom=70210)

select e.numcom, e.datcom
from entcom as e
join entcom as e70210 on e.numfou=e70210.numfou
where e70210.numcom=70210

--14.Dans les articles susceptibles d’être vendus, lister les articles moins chers (basés
--sur Prix1) que le moins cher des rubans (article dont le premier caractère
--commence par R). On affichera le libellé de l’article et prix1

select * from produit where codart in (
	select codart from vente where prix1 < (
		select min(prix1) from vente where codart in (
			select codart from Produit where libart like 'r%')))







--15.Editer la liste des fournisseurs susceptibles de livrer les produits dont le stock est
--inférieur ou égal à 150 % du stock d'alerte. La liste est triée par produit puis
--fournisseur

select * from Fournisseur where numfou in (
	select numfou from vente where codart in (
		select codart from produit
		where stkphy < stkale*1.5))

select distinct p.libart, f.nomfou
from Fournisseur as f
join vente as v on v.numfou=f.numfou
join Produit as p on p.codart=v.codart
where p.stkphy < p.stkale*1.5




--16.Éditer la liste des fournisseurs susceptibles de livrer les produit dont le stock est
--inférieur ou égal à 150 % du stock d'alerte et un délai de livraison d'au plus 30
--jours. La liste est triée par fournisseur puis produit
select distinct p.libart, f.nomfou
from Fournisseur as f
join vente as v on v.numfou=f.numfou
join Produit as p on p.codart=v.codart
where p.stkphy < p.stkale*1.5 and v.delliv<=30

select distinct p.libart, f.nomfou
from Fournisseur as f, vente as v , Produit as p 
where p.stkphy < p.stkale*1.5 and v.delliv<=30 and p.codart=v.codart and f.numfou=v.numfou






--17.Avec le même type de sélection que ci-dessus, sortir un total des stocks par
--fournisseur trié par total décroissant

select f.nomfou, sum(p.stkphy)
from Fournisseur as f
join vente as v on v.numfou=f.numfou
join Produit as p on p.codart=v.codart
where p.stkphy < p.stkale*1.5 and v.delliv<=30
group by f.nomfou






--18.En fin d'année, sortir la liste des produits dont la quantité réellement commandée
--dépasse 90% de la quantité annuelle prévue.

select produit.codart, sum(qtecde)
from produit 
join Ligcom on ligcom.codart=Produit.codart
group by produit.codart
having sum(qtecde)<(0.9*avg(produit.qteann))



--19.Calculer le chiffre d'affaire par fournisseur pour l'année 93 sachant que les prix
--indiqués sont hors taxes et que le taux de TVA est 20%.


select e.numfou, sum(l.qtecde*cast(l.priuni as money)) * 1.2 as 'Total TTC'
from ligcom as l
join entcom as e on l.numcom=e.numcom
group by e.numfou






--20.Existe-t-il des lignes de commande non cohérentes avec les produits vendus par
--les fournisseurs. ?select l.codart, e.numfoufrom Ligcom as ljoin Entcom as e on e.numcom=l.numcomEXCEPTselect codart, numfou from vente