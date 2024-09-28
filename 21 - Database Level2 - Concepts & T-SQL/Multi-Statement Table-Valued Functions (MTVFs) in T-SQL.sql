alter Function GetTopPerformingStudents()
Returns @Result Table (
  StudentID int,
  Name NVARCHAR(50),
  Subject NVARCHAR(50),
  Grade int
)
as 
begin 
  Insert Into @Result(StudentID,Name,Subject,Grade)
  select top 3 * from Students order by grade DESC
  return ;

end

select * from GetTopPerformingStudents() where Grade >=90