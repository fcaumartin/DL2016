create view vue1
as
select cli_id, cli_nom, cli_prenom, cli_ville from client


select * from vue1 where cli_ville like '%a%'





go
create proc listeClient
as
select cli_id, cli_nom, cli_prenom, cli_ville from client

exec listeClient 

drop proc listeClientParVille
go
create proc listeClientParVille
@ville varchar(50)
as
select cli_id, cli_nom, cli_prenom, cli_ville
from client
where cli_ville=@ville;
select cli_id, cli_nom, cli_prenom, cli_ville
from client
where cli_ville=@ville

exec listeClientParVille 'Londre'


go


create proc ajoutClient
@nom varchar(50), 
@prenom varchar(50), 
@ville varchar(50)
as
insert into client (cli_nom, cli_prenom, cli_ville) values
(@nom, @prenom, @ville)

exec ajoutClient 'toto', 'titi', 'Amiens'





