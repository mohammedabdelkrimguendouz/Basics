Select * From Employees

-- Value start a 
Select ID,FirstName,LastName From Employees
Where FirstName Like 'a%' 

-- Value end a 
Select ID,FirstName,LastName From Employees
Where FirstName Like '%a' 

-- Value start a and End a
Select ID,FirstName,LastName From Employees
Where FirstName Like 'a%a' 

-- Value Content 'tell' any position
Select ID,FirstName,LastName From Employees
Where FirstName Like '%tell%' 

-- Value  a  Position 3
Select ID,FirstName,LastName From Employees --  _ = Character
Where FirstName Like '__a%' 

-- Value  a  Position 4
Select ID,FirstName,LastName From Employees --  _ = Character
Where FirstName Like '___a%' 


Select ID,FirstName,LastName From Employees --  _ = Character
Where FirstName Like 'a__%' 

Select ID,FirstName,LastName From Employees --  _ = Character
Where FirstName Like 'a___%' 

Select ID,FirstName,LastName From Employees 
Where FirstName Like 'a%' Or  FirstName Like 'b%' 






