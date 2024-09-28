select * from Employees

select Employees.Name,Employees.ManagerID,Employees.Salary,
Case 
     When Manager.Name is null then Employees.Name
	 Else Manager.Name

END as ManagerName from Employees
Left Join Employees as Manager on Employees.ManagerID=Manager.EmployeeID