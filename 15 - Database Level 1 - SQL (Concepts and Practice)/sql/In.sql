Select * From Employees
Where DepartmentID=1 or DepartmentID=2

Select * From Employees
Where DepartmentID=1 or DepartmentID=2 or DepartmentID=7

Select * From Employees
Where DepartmentID In (1,2,3,5) -- In is short or

Select * From Employees
Where FirstName In ('Jacob','Bella','Jade','Harper') -- In is short or

Select DepartmentID From Employees 
Where MonthlySalary<=210

Select Departments.Name From Departments
Where ID In(Select DepartmentID From Employees Where MonthlySalary<=210)

Select Departments.Name From Departments
Where ID  not In(Select DepartmentID From Employees Where MonthlySalary<=210)

Select Departments.Name From Departments
Where ID In(Select DepartmentID From Employees Where ExitDate is not null)

Select Departments.Name From Departments
Where ID In(Select DepartmentID From Employees Where CountryID In(1,2) and Gendor='f')


