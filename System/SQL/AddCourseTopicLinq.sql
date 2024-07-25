declare @CourseCode int, @TopicCode int
select @CourseCode = (select code from Course where coursName = @courseName)
select @TopicCode = ( select code from Topic where topicName = @topic)
insert into CourseTopicLinq
values(@CourseCode, @TopicCode)