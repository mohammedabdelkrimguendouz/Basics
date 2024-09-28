select Makes.Make ,SUM(VehicleDetails.NumDoors) as TotalNumberOfDoorsFord from VehicleDetails
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
Group by Makes.Make
Having Makes.Make='Ford'
