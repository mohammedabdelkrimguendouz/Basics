select Bodies.BodyName,VehicleDetails.* from VehicleDetails
Inner Join Bodies on VehicleDetails.BodyID=Bodies.BodyID
where Bodies.BodyName IN('Coupe','Hatchback','Sedan')