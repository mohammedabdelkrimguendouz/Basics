
-- alter statment replcae create statment because update Procedure
Create Procedure SP_AddNewPerson
   @FirstName NvarChar(100),
   @LastName NvarChar(100),
   @Email NvarChar(255),
   @NewPersonID int Output
As
Begin
 Insert Into People(FirstName,LastName,Email)
 values(@FirstName,@LastName,@Email);

 set @NewPersonID=SCOPE_IDENTITY();
End

-- Execute stored prosedure
Declare @PersonID int;
Exec SP_AddNewPerson
@FirstName='ali',
@LastName=NULL,
@Email='ali@gmail.com',
@NewPersonID=@PersonID Output;


select * from People
