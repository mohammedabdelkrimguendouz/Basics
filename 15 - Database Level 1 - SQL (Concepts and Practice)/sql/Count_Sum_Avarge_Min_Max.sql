Select * From Employees

Select TotalCount=Count(MonthlySalary),TotalSum=Sum(MonthlySalary),
Avarge=Avg(MonthlySalary),MaxSalary=Max(MonthlySalary),MinSalary=Min(MonthlySalary)
From Employees

Select TotalCount=Count(MonthlySalary),TotalSum=Sum(MonthlySalary),
Avarge=Avg(MonthlySalary),MaxSalary=Max(MonthlySalary),MinSalary=Min(MonthlySalary)
From Employees
Where DepartmentID=1

Select TotalEmplyees=count(ID) From Employees

Select ResignedEmployees=count(ExitDate) From Employees -- Count Dont Count NULL

Select EmployeesWorks=Count(ID)-count(ExitDate) From Employees

