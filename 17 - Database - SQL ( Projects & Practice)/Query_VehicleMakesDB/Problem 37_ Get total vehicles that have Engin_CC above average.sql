
select  Count(*) as NumberOfVehiclesAboveAverageEngineCC  from 
(
select ID,VehicleDetails.Vehicle_Display_Name from VehicleDetails
Where Engine_CC>(select Avg(Engine_CC) From VehicleDetails)
)R1