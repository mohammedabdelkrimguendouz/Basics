select * from VehicleDetails
Where Engine_CC<(select Avg(Engine_CC) From VehicleDetails)