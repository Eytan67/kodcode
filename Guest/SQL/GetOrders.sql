select count(*) as amount, foodname
from categories c
join orders o on c.id = o.categorieid
join guests g on o.guestid = g.id
where c.categoryname = @categoryname
and g.guestname != @guestname
group by foodname


