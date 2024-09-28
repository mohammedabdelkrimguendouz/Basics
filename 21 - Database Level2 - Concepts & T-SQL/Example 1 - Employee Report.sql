Declare @DepartmentID int;
Declare @StartDate Date;
Declare @EndDate Date;
Declare @TotalEmployees int;
Declare @DepartmentName VARCHAR(50);

set @DepartmentID=3;
set @StartDate='2023-01-01';
set @EndDate='2023-12-30';

select @DepartmentName=Name from Departments where DepartmentID=@DepartmentID;

select @TotalEmployees = Count(*) from Employees
Where DepartmentID=@DepartmentID 
And (HireDate between @StartDate And @EndDate);


Print 'Department Report';
Print 'Department Name : ' + @DepartmentName;
Print 'Reporting Period : ' +Cast(@StartDate as VarChar) + ' to ' + Cast(@EndDate as VarChar);
Print 'Total Employee Hired In '+Cast(Year(@StartDate) as VarChar) + ' : '+Cast(@TotalEmployees as VarChar);

