Select * From Employees

Select Top 5 * From Employees

Select Top 5 Percent * From Employees --   == 5% From Data

Select MonthlySalary From Employees
Order By MonthlySalary Desc

Select Distinct MonthlySalary From Employees
Order By MonthlySalary Desc

Select Distinct Top 3 MonthlySalary From Employees
Order By MonthlySalary Desc


Select ID,FirstName,MonthlySalary From Employees Where MonthlySalary In
(
 Select Distinct Top 3 MonthlySalary From Employees
 Order By MonthlySalary Desc
)
Order By MonthlySalary Desc



Select ID,FirstName,MonthlySalary From Employees Where MonthlySalary In
(
 Select Distinct Top 3 MonthlySalary From Employees
 Order By MonthlySalary Asc
)
Order By MonthlySalary Asc



Select ID,FirstName,LastName,MonthlySalary From Employees Where MonthlySalary In
(
Select Distinct  Top 10 MonthlySalary From Employees
Order By MonthlySalary Desc
)
Order By MonthlySalary Desc





