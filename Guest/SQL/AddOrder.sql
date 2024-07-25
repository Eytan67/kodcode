declare @catId varchar(50)
select @catId = (select Categories.id from Categories where Categories.CategoryName = @categoryName)

declare @guId varchar(50)
select @guId = (select Guests.id from Guests where Guests.GuestName = @guestName)

insert into Orders
values(@foodName, @catId, @guId)