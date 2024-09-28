select Distinct Makes.Make,FuelTypes.FuelTypeName from VehicleDetails 
Inner Join FuelTypes on VehicleDetails.FuelTypeID=FuelTypes.FuelTypeID
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
where FuelTypes.FuelTypeName=N'GAS' /* "N" Because search unicode*/
Order By Makes.Make