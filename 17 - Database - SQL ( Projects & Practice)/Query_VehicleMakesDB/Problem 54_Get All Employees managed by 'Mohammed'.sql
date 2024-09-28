select Employees.Name,Employees.ManagerID,Employees.Salary,Manager.Name as ManagerName from Employees
Left Join Employees as Manager on Employees.ManagerID=Manager.EmployeeID
Where Manager.Name='Mohammed'