
create Procedure SP_GetPersonInfoByID2
  @PersonID int,
  @FirstName NvarChar(100) output,
  @LastName NvarChar(100) output,
  @Email NvarChar(255) output,
  @IsFound bit output
  as
  Begin
    if(Exists(select 1 from People where PersonID=@PersonID))
	 Begin
	   select 
	   @FirstName=FirstName,
	   @LastName=LastName,
	   @Email=Email from People
	   where PersonID=@PersonID;
	   set @IsFound=1;
	  End
	Else
	   set @IsFound=0
  End

  -- Exec Prosedure
  Declare @ID int =2;
  Declare @FName NVARCHAR(100);
  Declare @LName NvarChar(100);
  Declare @Email NvarChar(255);
  Declare @Found bit;

  Exec SP_GetPersonInfoByID2
   @PersonID=@ID,
   @FirstName=@FName output,
   @LastName=@LName output,
   @Email=@Email output,
   @IsFound=@Found output;

   if(@Found=0)
     Print ' Person not found ';
	else
	 select @FName as FirstName , @LName as LastName ,@Email as Email;
