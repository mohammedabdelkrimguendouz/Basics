Create Table Person3
(
ID int Not null,
LastName nvarchar(255) Not Null,
FirstName nvarchar(255) ,
Age int Check(Age>=18)
)

Select * From Person3

Create Table Person4
(
ID int Not null,
LastName nvarchar(255) Not Null,
FirstName nvarchar(255) ,
Age int ,
City nvarchar(255),
Constraint CHK_Person Check(Age>=18 and City='Amman')
)

Select * From Person4

Alter Table Person4
Drop Constraint CHK_Person