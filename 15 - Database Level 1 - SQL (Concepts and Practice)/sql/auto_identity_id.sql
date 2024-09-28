Select * From Departements;

Create Table Departements(
ID int Identity(1,1) Not Null,
Name nvarchar(100) Not Null
Primary Key(ID)
);

Insert Into Departements
Values
('Info');

Print @@Identity

Delete  From Departements; -- delete data from table && allow where statment && not reset count identity

Truncate Table Departements; -- delete data from table && reset count identity && not allow where statment