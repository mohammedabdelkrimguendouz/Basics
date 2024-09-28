Create Table Customers(
ID int Identity(1,1) Not Null,
FirstName nvarchar(40) ,
LastName nvarchar(40) ,
Age int ,
Country nvarChar(10),
Primary Key(ID)
);

Create Table Orders(
OrderID int Identity(1,1) Not Null,
Item nvarchar(40) ,
Amount int,
CustomersID int  References Customers(ID), -- Foreigne Key 
Primary Key(OrderID)
);

--Alter Table Orders   
--Add Foreign Key (CustomersID) References Customers(ID);




