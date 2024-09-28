select Bodies.BodyName,VehicleDetails.* from VehicleDetails
Inner Join Bodies on VehicleDetails.BodyID=Bodies.BodyID
where Bodies.BodyName='Sport Utility' and VehicleDetails.Year>2020