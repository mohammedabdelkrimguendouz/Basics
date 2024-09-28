
select Makes.Make ,COUNT(*) as NumberOfVehiles from VehicleDetails
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
Where VehicleDetails.Year between 1950 and  2000 
group by Makes.Make
Having COUNT(*) >12000
Order by NumberOfVehiles DESC


/* dont using Having */
select * from 
(
select Makes.Make ,COUNT(*) as NumberOfVehiles from VehicleDetails
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
Where VehicleDetails.Year between 1950 and  2000 
group by Makes.Make
)R1
where R1.NumberOfVehiles>12000
order by NumberOfVehiles DESC

/* Having--> result */
/* where --> data */