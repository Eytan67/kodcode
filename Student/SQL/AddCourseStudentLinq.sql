declare @CourseCode int, @coursePrice int, @StudentCode int

select @CourseCode = (select code from Course where coursName = @coursName)
select @coursePrice = (select coursePrice from Course where coursName = @coursName)
select @StudentCode = ( select code from Student where studentName = @studentName)
insert into CourseStudentLinq
values(@CourseCode, @StudentCode)

update Student
set debt = (Student.debt + @coursePrice)
where code = @StudentCode