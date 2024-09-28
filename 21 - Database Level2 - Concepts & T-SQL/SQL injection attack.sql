
    DECLARE @SQL NVARCHAR(MAX);
    SET @SQL = N'SELECT * FROM Employees where EmployeeID=1 or 1=1';

	Print @SQL

	Execute(@SQL);