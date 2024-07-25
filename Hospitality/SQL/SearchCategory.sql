select CategoryName from Categories
where CategoryName like '%' + @str + '%'