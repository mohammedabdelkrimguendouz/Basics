select Employees.EmployeeID,Employees.Name,Employees.Salary,Manager.Name as ManagerName from Employees
Inner Join Employees as Manager on Employees.ManagerID=Manager.EmployeeID