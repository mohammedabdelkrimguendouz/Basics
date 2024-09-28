select Distinct VehicleDetails.MakeID,Makes.Make,SubModels.SubModelName from VehicleDetails
Inner Join Makes on VehicleDetails.MakeID=Makes.MakeID 
Inner Join SubModels on VehicleDetails.SubModelID=SubModels.SubModelID
Where SubModels.SubModelName='Elite'