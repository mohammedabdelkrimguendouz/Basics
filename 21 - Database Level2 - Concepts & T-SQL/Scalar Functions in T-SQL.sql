

Create Function GetAverageGrade(@Subject NVARCHAR(50))
RETURNS INT

AS
BEGIN
  declare @AverageGrade int;
  select @AverageGrade =Avg(Grade) 
  from Students 
  where Subject=@Subject;

  return @AverageGrade;

END





------------------------------ (TEST GetAverageGrade FUNCTION)

select * from Teachers

SELECT Name,Subject, dbo.GetAverageGrade(Subject)*1.1 AS AverageGrade
FROM Teachers;




------------------------- Without GetAverageGrade Function
SELECT Name,Subject,(select Avg(Grade)  from Students  where Subject=T.Subject) AS AverageGrade
FROM Teachers T;




-------------------------------------

Create Function CalculateBouns(@PerformanceRating int,@Salary smallmoney)
returns smallmoney
as
begin


  declare @Bouns SmallMoney;
  if (@PerformanceRating>=5)
     set @Bouns=@Salary*1.0;
  else
     set @Bouns=@Salary*0.05;

	 return @Bouns;
end


-----------------------------------------------


