Create Procedure SP_GetAllPeople
as 
begin

select * from People;

end

-- Execute Procedure
Exec SP_GetAllPeople;