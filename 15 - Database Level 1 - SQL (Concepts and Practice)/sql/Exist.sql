
Select X='YES'
Where Exists
(
Select * From Orders
Where CustomerID=3 And Amount<600
)




Select * From Customers T1
Where Exists
(
Select * From Orders
Where CustomerID=T1.CustomerID And Amount<600
)



Select * From Customers T1
Where Exists
(
Select Top 1 * From Orders
Where CustomerID=T1.CustomerID And Amount<600
)

-- Best
Select * From Customers T1
Where Exists
(
Select Top 1 R='Y' From Orders
Where CustomerID=T1.CustomerID And Amount<600
)
