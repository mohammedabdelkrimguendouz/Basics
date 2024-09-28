select  Makes.Make, SUM(VehicleDetails.NumDoors) as TotalNumberOfDoors from VehicleDetails
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
Group by Makes.Make
Order By TotalNumberOfDoors
