declare  @code int, @answer VARCHAR(250),  @test VARCHAR(250);
IF exists (select * from Employees where id= @id)
	begin
		select @code = (select code from Employees where id=@id)
	end
else
	begin
		INSERT into Employees values ( @id, @full_name);
		select @code=@@IDENTITY;
	end

IF exists (select * from Passwords WHERE employee_code = @code)
	begin
		if exists (select password_string From Passwords
					WHERE employee_code=@code AND password_string=@password
					AND has_access=1 )
			begin
				if exists (select password_string From Passwords
					WHERE employee_code=@code AND password_string=@password
					AND has_access=1 AND  password_expiry_date>=getdate())
					begin
						IF exists (SELECT * FROM Clock_Time
							WHERE employee_code=@code AND exit_time is null)
							begin 								
								UPDATE Clock_Time set exit_time=GETDATE()
								WHERE employee_code=@code AND exit_time is null;
								select @answer='Exit time: ' + CONVERT (NVARCHAR, GETDATE(), 121);
							end
						else
							begin
								INSERT INTO Clock_Time  VALUES (@code, GETDATE(), null);
								select @answer='Entry time: ' + CONVERT (NVARCHAR, GETDATE(), 121);
							end
					end
					ELSE
						begin
							select @answer= 'you need to update your password';
						end
			end
		ELSE
			begin
			select @answer = 'wrong password';
			end
	end
ELSE
	begin
		INSERT INTO	Passwords VALUES (@code, @password,
		DATEADD(day, 180, GETDATE()),
		1)
		INSERT INTO OldPass VALUES (@code, @password)
		select @answer= 'You created a worker and password';
	end
select @answer
