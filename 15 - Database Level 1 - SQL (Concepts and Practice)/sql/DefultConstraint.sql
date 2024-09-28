
Create Table Person
(
ID Int Not Null,
LastName nvarchar(255) Not null,
FirstName nvarchar(255),
Age int,
City nvarchar(255) Default 'Amman'
);

Select * From Person


Create Table Orders
(
ID int NOT NULL,
OrderNumber int NOT NULL,
OrderDate Date default GetDate()
)

Select * From Orders



Create Table Person2
(
ID Int Not Null,
LastName nvarchar(255) Not null,
FirstName nvarchar(255),
Age int,
City nvarchar(255)
);
Alter Table Person2
Add Constraint df_City
default 'Amman' for City

Alter Table Person2
Drop Constraint df_City

