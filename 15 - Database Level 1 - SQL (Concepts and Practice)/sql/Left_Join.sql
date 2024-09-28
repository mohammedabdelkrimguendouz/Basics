
Select * From Customers
Select * From Orders

Select Customers.CustomerID,Customers.Name,Orders.Amount From Customers Left Join Orders ON
Customers.CustomerID=Orders.CustomerID

Select Customers.CustomerID,Customers.Name,Orders.Amount From Customers Left Outer Join Orders ON
Customers.CustomerID=Orders.CustomerID




