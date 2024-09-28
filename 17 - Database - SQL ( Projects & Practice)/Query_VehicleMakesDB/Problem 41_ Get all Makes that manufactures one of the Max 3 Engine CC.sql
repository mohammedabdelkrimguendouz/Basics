select Distinct Makes.Make from VehicleDetails
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID
Where Engine_CC in 
(
select distinct top 3 VehicleDetails.Engine_CC from VehicleDetails
order by Engine_CC DESC
)
order By Makes.Make