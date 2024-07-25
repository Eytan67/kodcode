declare @catId varchar(50)
select @catId = (select Categories.id from Categories where Categories.CategoryName = @categoryName)
delete from Orders
where Orders.CategorieId = @catId
delete from Categories
where Categories.id = @catId