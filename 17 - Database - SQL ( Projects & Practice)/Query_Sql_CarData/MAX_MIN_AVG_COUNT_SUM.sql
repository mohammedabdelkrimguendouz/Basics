select * from CarDetails;

select COUNT(*) from CarDetails;

select COUNT( Distinct Make) from CarDetails;

select Make, COUNT(*) as TotalCars from CarDetails group by Make;

select SUM(Engine_CC) from CarDetails;

select AVG(Engine_CC) From CarDetails;

select NumDoors, AVG(Year) from CarDetails group by NumDoors;

select Min(Year) from CarDetails;


select Make,Min(Engine_CC) from CarDetails group by Make;

select Max(Year) from CarDetails;


select Body,Max(Engine_CC) from CarDetails group by Body;

select Make, Count(*) as TotalCars,Avg(Year) as AvargeMakeYear,Min(Engine_CC) as MinEngine_CC,Max(Engine_CC) as MaxEngine_CC from CarDetails group by Make;

select Fuel_Type_Name ,count(*) as CountCars,SUM(Engine_CC) as SumEngine_CC,AVG(Engine_CC) as AvgEngine_CC ,MIN(Year) as MinMakeYear,MAX(Year) as MaxMakeYear from CarDetails group by Fuel_Type_Name;