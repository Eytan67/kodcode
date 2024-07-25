select count(*) as Amount, FoodName
from Categories C
join Orders O on C.Id = O.CategorieId
where C.CategoryName = @categoryName
group by FoodName