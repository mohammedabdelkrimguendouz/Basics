Select TotalCount=Count(MonthlySalary),TotalSum=Sum(MonthlySalary),
Avarge=Avg(MonthlySalary),MaxSalary=Max(MonthlySalary),MinSalary=Min(MonthlySalary)
From Employees

Select DepartmentID, TotalCount=Count(MonthlySalary),TotalSum=Sum(MonthlySalary),
Avarge=Avg(MonthlySalary),MaxSalary=Max(MonthlySalary),MinSalary=Min(MonthlySalary)
From Employees
Group By DepartmentID
Order By DepartmentID Asc

Select CountryID, TotalCount=Count(MonthlySalary),TotalSum=Sum(MonthlySalary),
Avarge=Avg(MonthlySalary),MaxSalary=Max(MonthlySalary),MinSalary=Min(MonthlySalary)
From Employees
Group By CountryID
Order By CountryID Asc

