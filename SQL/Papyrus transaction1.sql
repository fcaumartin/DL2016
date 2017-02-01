BEGIN TRAN
PRINT 'Valeur de Trancount: ' + CAST(@@TRANCOUNT AS varchar(5))
PRINT 'Avant MaJ:'
SELECT nomfou FROM fournisseur WHERE numfou=120
UPDATE fournisseur
SET nomfou= 'LEBRIGAND' WHERE numfou=120
PRINT 'Après MaJ:'
SELECT nomfou FROM fournisseur WHERE numfou=120
PRINT 'Valeur de Trancount: ' + CAST(@@TRANCOUNT AS varchar(5))

COMMIT
ROLLBACK
