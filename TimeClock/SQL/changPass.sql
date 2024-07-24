DECLARE @code INT, @answer VARCHAR(250)
if exists ( select 1 from Employees where @id = id ) 
	begin
		select @code = (select code from Employees where @id = id )
		if exists( select 1 from Passwords where employee_code = @code and password_string = @oldPass )
			if exists( select 1 from OldPass where employee_code = @code and @newPass = Pass)
			begin
				select @answer = 'chooce a difrent password!'
			end
			else
			begin 
				update Passwords
				set password_string = @newPass
				where employee_code = @code
				select @answer = 'it works!'
			end
		else
			begin
				select @answer = 'passowrd or id is nn corect!'
			end
	end
else
	begin
		select @answer = 'passowrd or id is nn corect!'
	end
select @answer