select * from reservation

begin transaction
	delete from reservation
	begin transaction
		delete from reservation

	commit transaction

commit transaction 


