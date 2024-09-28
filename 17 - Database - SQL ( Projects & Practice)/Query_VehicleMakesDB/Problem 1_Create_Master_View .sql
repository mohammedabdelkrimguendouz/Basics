select * from VehicleDetails;

Create View VehcileMasterDetails AS
select VehicleDetails.ID,VehicleDetails.MakeID,Makes.Make,VehicleDetails.ModelID,MakeModels.ModelName,VehicleDetails.SubModelID,SubModels.SubModelName,VehicleDetails.BodyID,Bodies.BodyName,
VehicleDetails.Vehicle_Display_Name,VehicleDetails.Year,VehicleDetails.DriveTypeID,DriveTypes.DriveTypeName,
VehicleDetails.Engine,VehicleDetails.Engine_CC,VehicleDetails.Engine_Cylinders,VehicleDetails.Engine_Liter_Display,
VehicleDetails.FuelTypeID ,FuelTypes.FuelTypeName,VehicleDetails.NumDoors
from VehicleDetails Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
Inner Join MakeModels on VehicleDetails.ModelID=MakeModels.ModelID
Inner Join  SubModels on  VehicleDetails.SubModelID=SubModels.SubModelID
Inner Join Bodies on VehicleDetails.BodyID=Bodies.BodyID 
Inner Join DriveTypes on VehicleDetails.DriveTypeID=DriveTypes.DriveTypeID
Inner Join FuelTypes on VehicleDetails.FuelTypeID=FuelTypes.FuelTypeID

select * from VehcileMasterDetails;