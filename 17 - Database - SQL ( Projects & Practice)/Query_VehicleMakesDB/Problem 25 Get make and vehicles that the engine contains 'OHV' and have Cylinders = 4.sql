select Makes.Make ,VehicleDetails.* from VehicleDetails
Inner Join Makes on Makes.MakeID=VehicleDetails.MakeID
where VehicleDetails.Engine like '%OHV%' and VehicleDetails.Engine_Cylinders=4