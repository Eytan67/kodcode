select entry_time, exit_time
from Clock_Time CT 
join Employees E on E.code = CT.code
where E.id = @id
