select * from fournisseur where numfou=120

if @@ROWCOUNT>0
	print 'ok'
else 
	print 'vide'
	
	
declare @nombre int
set @nombre = (select count(*) from fournisseur where numfou=55)

if @nombre>0
	print 'ok'
else 
	print 'vide'

	
if EXISTS (select * from fournisseur where numfou=55)
	print 'ok'
else 
	print 'vide'

