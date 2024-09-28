select * from CarDetails;

select Make,Count(*) from CarDetails group by Make;

select Body,AVG(Engine_CC) from CarDetails Group By Body;

select Drive_Type,Count(*) from CarDetails group by Drive_Type;

select Fuel_Type_Name,AVG(Engine_Cylinders) from CarDetails group by Fuel_Type_Name;

select Year ,Max(Engine_CC) as MaxEngine_CC,Min(Engine_CC) as MinEngine_CC from CarDetails group by Year;

select NumDoors,AVG(Year) as AvgMakeYear ,Count(*) as TotalCars from CarDetails group by NumDoors;

select Make,model ,AVG(Engine_CC) as AvgEngine_CC,Count(*)as TotalCars from CarDetails group by Make,Model;

select  Fuel_Type_Name,Drive_Type, Count(*) as TotalCars,AVG(Engine_CC) as AvgEngine_CC from CarDetails Group by Fuel_Type_Name,Drive_Type;

select Drive_Type,Body ,AVG(Year) as AvgMakeYear,Max(Year) as MaxMakeYear,Min(Year) as MinMakeYear from CarDetails  Group by Drive_Type,Body;

select top 1  Make,COUNT(DISTINCT Model) as ModleCount from CarDetails group by Make order by ModleCount DESC; 