
Select A=5*4 , B=6/2

Select A=5*4 , B=6/2 From Employees

Select ID,FirstName,A=MonthlySalary/2 From Employees

Select ID, FirstName+' '+LastName as FullName From Employees 

Select ID,FullName=FirstName+' '+LastName From Employees

Select ID,FirstName,MonthlySalary,YearlySalary=MonthlySalary*12 From Employees

Select ID,FirstName,MonthlySalary,YearlySalary=MonthlySalary*12 , BounsAmount = MonthlySalary* BonusPerc From Employees

Select ID,FirstName+' '+LastName As FullName,ExitDate,GETDATE() As Today,DateOfBirth,DateDiff(Year,DateOfBirth,GetDate()) As Age From Employees

