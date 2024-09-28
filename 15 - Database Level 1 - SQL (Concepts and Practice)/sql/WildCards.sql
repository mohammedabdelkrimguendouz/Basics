
Select * From Employees

Update Employees
Set FirstName='Mohammed',LastName='Guendouz'
Where ID=285

Update Employees
Set FirstName='Mohammad',LastName='Maher'
Where ID=286

-- Search From Mohammed or mohammad
Select ID,FirstName,LastName From Employees
Where FirstName='Mohammed' Or FirstName='Mohammad'

-- Search From Mohammed or mohammad
Select ID,FirstName,LastName From Employees
Where FirstName like 'Mohamm[ae]d' 

Select ID,FirstName,LastName From Employees
Where FirstName Not like 'Mohamm[ae]d' 

Select ID,FirstName,LastName From Employees
Where FirstName like 'a%' Or FirstName like 'b%' Or FirstName like 'c%'

--Search for all employees first name start with a or b or c
Select ID,FirstName,LastName From Employees
Where FirstName like '[abc]%'

--Search for all employees first name start with letter from a to l
Select ID,FirstName,LastName From Employees
Where FirstName like '[a-l]%'


