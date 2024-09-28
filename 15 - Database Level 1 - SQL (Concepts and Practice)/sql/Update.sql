
Select * From Employees;

Update Employees
Set Name='karim guendouz'
where ID=1;

Update Employees
Set Name='karim guendouz',Salary=5000
where ID=1;

Update Employees
Set Salary= Salary+200
where Salary<1000;

Update Employees
set Salary=Salary+(10*Salary/100)
Where Salary<=1000

