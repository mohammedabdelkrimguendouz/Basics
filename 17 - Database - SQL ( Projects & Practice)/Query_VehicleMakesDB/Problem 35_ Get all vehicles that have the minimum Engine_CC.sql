
select * from VehicleDetails
Where Engine_CC=(select Max(Engine_CC) From VehicleDetails)


