select * from CarDetails;

select Make as Brand From CarDetails;

select Year as YearOfManuFacture ,numDoors as NumberOfDoors From CarDetails;

select Make ,AVG(engine_liter_display) as AvargeEngineCapacity From CarDetails group by Make;

select MAX(Year)-MIN(Year) As YearRange from CarDetails;

select model,Make,count(*) as TotalCars From CarDetails group by Make,Model;

select model,Make,Year,CONCAT(Make,' ',Model) as FullModelName  From CarDetails;


