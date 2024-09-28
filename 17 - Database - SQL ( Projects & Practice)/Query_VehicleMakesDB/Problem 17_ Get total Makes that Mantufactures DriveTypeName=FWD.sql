
select Count(*) as MakeWithFWD from 
(
select Distinct Makes.Make,DriveTypes.DriveTypeName From VehicleDetails 
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
Inner Join DriveTypes on VehicleDetails.DriveTypeID =DriveTypes.DriveTypeID
where DriveTypes.DriveTypeName='FWD'
)R1
