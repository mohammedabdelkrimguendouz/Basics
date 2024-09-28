-- filter datad after group by

Select DepartmentID, TotalCount=Count(MonthlySalary),TotalSum=Sum(MonthlySalary),
Avarge=Avg(MonthlySalary),MaxSalary=Max(MonthlySalary),MinSalary=Min(MonthlySalary)
From Employees
Group By DepartmentID
Having Count(MonthlySalary)>100
Order By DepartmentID Asc


Select * From (

Select DepartmentID, TotalCount=Count(MonthlySalary),TotalSum=Sum(MonthlySalary),
Avarge=Avg(MonthlySalary),MaxSalary=Max(MonthlySalary),MinSalary=Min(MonthlySalary)
From Employees
Group By DepartmentID
)R1
Where R1.TotalCount>100
Order By R1.DepartmentID  Asc

