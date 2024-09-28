Create Procedure SP_UpdatePrson
  @PersonID int,
  @FirstName NVARCHAR(100),
  @LastName NVARCHAR(100),
  @Email NVARCHAR(100)
as 
begin
Update People 
set FirstName=@FirstName,
    LastName=@LastName,
	Email=@Email
	Where PersonID=@PersonID;
end


Exec SP_UpdatePrson
 @PersonID=3,
 @FirstName='koko',
 @LastName='koko',
 @Email='koko@gmail.com'

 select * from People Where PersonID=3;
 
