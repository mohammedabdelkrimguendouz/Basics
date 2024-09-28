
Select * From Employees


Select * From
(
Select * From Employees
Where ExitDate is Null
)R1


--Create View ActiveEmployees As 
Select * From Employees
Where ExitDate is Null

--Create View ResignedEmployees As 
Select * From Employees
Where ExitDate is not Null


Select * From ActiveEmployees
Where ID=285

Select * From ResignedEmployees

--Create View ShortDetailedEmployees As
Select ID,FirstName,LastName,Gendor From Employees

Select * From ShortDetailedEmployees
