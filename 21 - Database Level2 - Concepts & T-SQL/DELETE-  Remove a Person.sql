create Procedure SP_DeletePerson
  @PersonID int
as
begin
delete People where PersonID= @PersonID;

end

Exec SP_DeletePerson
@PersonID=2

select * from People