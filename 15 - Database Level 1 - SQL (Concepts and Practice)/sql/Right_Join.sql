

SELECT        Customers.CustomerID, Customers.Name, Orders.Amount
FROM            Customers INNER JOIN
                         Orders ON Customers.CustomerID = Orders.CustomerID
SELECT        Customers.CustomerID, Customers.Name, Orders.Amount
FROM            Customers LEFT OUTER JOIN
                         Orders ON Customers.CustomerID = Orders.CustomerID

SELECT        Customers.CustomerID, Customers.Name, Orders.Amount
FROM            Customers RIGHT OUTER JOIN
                         Orders ON Customers.CustomerID = Orders.CustomerID

SELECT        Customers.CustomerID, Customers.Name, Orders.Amount
FROM            Customers FULL OUTER JOIN
                         Orders ON Customers.CustomerID = Orders.CustomerID