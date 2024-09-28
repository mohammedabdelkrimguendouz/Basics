select * from VehicleDetails
Where Engine_CC=(select MAX(Engine_CC) From VehicleDetails)