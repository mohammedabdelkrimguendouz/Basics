
select Makes.Make ,COUNT(*) as NumberOfVehcils from VehicleDetails 
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID 
where VehicleDetails.Year Between 1950 and 2000
group by Makes.Make order By NumberOfVehcils DESC

