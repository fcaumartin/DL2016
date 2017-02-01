--insert -> inserted

--delete -> deleted

--update
--	-> deleted
--	-> inserted



--drop trigger toto2 
create trigger toto2
on station
for insert
as
declare @altitude int
set @altitude = (select sta_altitude from inserted)
if (@altitude<1000)
	begin
		print 'pas assez haut !'
		rollback
	end


insert into station (sta_nom, sta_altitude) values ('sta1', 300)