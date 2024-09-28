

select distinct Makes.Make,DriveTypes.DriveTypeName,Count(*) AS Total From VehicleDetails 
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
Inner Join DriveTypes on VehicleDetails.DriveTypeID =DriveTypes.DriveTypeID
group by Makes.Make,DriveTypes.DriveTypeName
Having COUNT(*) >10000
Order by Makes.Make ASC ,Total DESC