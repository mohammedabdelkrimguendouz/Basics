
create Procedure SP_GetPersonInfoByID
  @PersonID int
as 
Begin
 select * from People where PersonID=@PersonID;
end

Exec SP_GetPersonInfoByID
 @PersonID=1

