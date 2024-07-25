declare @lecturerCode int = (
	select code
	from Lecturer
	where Lecturer.lecturerName = @lecturer
)
insert into Topic
values (@topic, @hours, @lecturerCode)