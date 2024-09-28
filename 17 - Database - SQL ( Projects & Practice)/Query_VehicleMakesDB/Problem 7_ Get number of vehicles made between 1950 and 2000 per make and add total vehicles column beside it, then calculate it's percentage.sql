

select *, Cast(NumberOfVehiles as float) /Cast( TotalVehciles as float) as Pers  from 
(
select Makes.Make ,COUNT(*) as NumberOfVehiles,(select Count(*) from VehicleDetails) as TotalVehciles from VehicleDetails
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
Where VehicleDetails.Year between 1950 and  2000 
group by Makes.Make
)R1
Order by  NumberOfVehiles DESC
