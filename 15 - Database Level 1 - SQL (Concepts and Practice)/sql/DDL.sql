
use DB1;
create table Employee(
ID int not null,
Name nvarchar(20) null,
phonee nvarchar(10) null,
Email nvarchar(70) null,
primary key (ID)
);

alter table Employee
add Gender char(1) not null,Salary float null

exec sp_rename 'Employee.Phonee','Phone','column'

exec sp_rename 'Employee','Employees'

alter table Employees
drop column Email

alter table Employees
alter column Name nvarchar(50) not null









