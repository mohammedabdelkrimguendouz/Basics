select  Makes.Make ,FuelTypes.FuelTypeName ,Count(*) as NumberOfVehciles From VehicleDetails
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
Inner Join FuelTypes on VehicleDetails.FuelTypeID=FuelTypes.FuelTypeID
Where VehicleDetails.Year between 1950 and  2000 
group by Makes.Make,FuelTypes.FuelTypeName
Order By Makes.Make