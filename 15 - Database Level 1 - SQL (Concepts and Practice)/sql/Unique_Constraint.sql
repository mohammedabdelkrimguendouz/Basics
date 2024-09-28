
Create Table Person5
(
ID int Unique,
LastName nvarchar(255) not null,
FirstName nvarchar(255),
Age int
)

Select * From Person5

Create Table Person6
(
ID int ,
LastName nvarchar(255) not null,
FirstName nvarchar(255),
Age int
Constraint UC_Person6 Unique(ID,FirstName)
)

Alter Table Person6
Add Unique (ID)

Alter Table Person6
Add Constraint UC_Person6 Unique(ID,FirstName)


Alter Table Person6
Drop Constraint UC_Person6

