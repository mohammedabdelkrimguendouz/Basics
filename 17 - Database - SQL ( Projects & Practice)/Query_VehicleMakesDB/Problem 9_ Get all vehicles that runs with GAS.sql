select *,FuelTypes.FuelTypeName from VehicleDetails 
Inner Join FuelTypes on VehicleDetails.FuelTypeID=FuelTypes.FuelTypeID
where FuelTypes.FuelTypeName=N'GAS' /* N Because search unicode*/