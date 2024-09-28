
select 
(
Cast( (select Count(*) as TotalWithNoSpecifiedDoors From VehicleDetails 
where  NumDoors is NULL) as float)
/
Cast( (select Count(*) as TotalVehciles  From VehicleDetails ) as float)
) as PersOfNoSpecifiedDoors