

SELECT Employees.ID, Employees.FirstName, Employees.LastName, Departments.Name FROM Departments INNER JOIN Employees ON 
Departments.ID = Employees.DepartmentID




SELECT Employees.ID, Employees.FirstName, Employees.LastName, Departments.Name FROM Departments INNER JOIN Employees ON 
Departments.ID = Employees.DepartmentID
Where Departments.Name='IT'

SELECT Employees.FirstName, Employees.LastName, Departments.Name As DeptName,Countries.Name As CountName FROM Departments INNER JOIN Employees  ON 
Departments.ID = Employees.DepartmentID Inner Join Countries ON Employees.CountryID=Countries.ID

SELECT Employees.ID, Employees.FirstName, Employees.LastName, Departments.Name As DeptName,Countries.Name As CountryName FROM Departments INNER JOIN Employees  ON 
Departments.ID = Employees.DepartmentID Inner Join Countries ON Employees.CountryID=Countries.ID
Where Countries.Name='USA'



