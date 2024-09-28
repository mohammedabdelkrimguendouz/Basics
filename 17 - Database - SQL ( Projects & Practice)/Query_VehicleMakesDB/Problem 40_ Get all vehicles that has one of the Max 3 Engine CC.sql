
select * from VehicleDetails
Where Engine_CC in 
(
select distinct top 3 VehicleDetails.Engine_CC from VehicleDetails
order by Engine_CC DESC
)