alter Procedure SP_IsPersonExist
  @PersonID int
as
begin
 if(Exists(select IsFound=1 from People where PersonID=@PersonID))
   return  1;
 else
   return 0;

end

declare @IsFound bit;

Exec  @IsFound= SP_IsPersonExist
@PersonID=1

if(@IsFound=1)
  Print ' Person Exist ';
else
  Print ' Person not Exist ';

