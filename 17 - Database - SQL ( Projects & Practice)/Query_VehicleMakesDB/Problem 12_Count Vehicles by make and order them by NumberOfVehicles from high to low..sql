select Makes.Make ,Count(*) as NumberOfVehciles from VehicleDetails
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
group by Makes.Make
Order by NumberOfVehciles DESC