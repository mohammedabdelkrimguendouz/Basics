
Select ID ,FirstName,LastName,GenderTitle=
Case
   When Gendor='M' Then 'Male'
   When Gendor='F' Then 'Female'
   Else 'Unknow'
End
From Employees




Select ID ,FirstName,LastName,GenderTitle=
Case
   When Gendor='M' Then 'Male'
   When Gendor='F' Then 'Female'
   Else 'Unknow'
End,
Status=
Case
   When ExitDate Is Null Then 'Active'
   When ExitDate Is Not Null Then 'Resigned'
End
From Employees


Select ID ,FirstName,LastName,MonthlySalary,NewSalaryToBe=
Case
   When Gendor='M' Then MonthlySalary*1.1
   When Gendor='F' Then MonthlySalary*1.5
End
From Employees



