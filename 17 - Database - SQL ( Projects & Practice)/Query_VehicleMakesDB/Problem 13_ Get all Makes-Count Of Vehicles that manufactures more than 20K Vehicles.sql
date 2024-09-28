select Makes.Make ,Count(*) as NumberOfVehciles from VehicleDetails
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
group by Makes.Make
Having COUNT(*) >20000
Order by NumberOfVehciles DESC

/* dont using having */

select * from 
(
select Makes.Make ,Count(*) as NumberOfVehciles from VehicleDetails
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
group by Makes.Make
)R1
where NumberOfVehciles>20000
Order by NumberOfVehciles DESC