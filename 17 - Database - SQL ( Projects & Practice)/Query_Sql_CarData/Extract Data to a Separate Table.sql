select * from CarDetails;


Insert Into  Makes
select distinct Make from CarDetails order by Make;

select * from Makes;

Update CarDetails
set MakeID=(select MakeID from Makes where MakeName=CarDetails.Make);

select Makes.MakeName,CarDetails.* from CarDetails Inner Join Makes on CarDetails.MakeID =Makes.MakeID

Insert Into  models
select distinct Model from CarDetails order by Model;

select * from models;

Update CarDetails 
set ModelID=(select ModelID from Models where CarDetails.Model=ModelName);

select Models.ModelName,CarDetails.* from CarDetails Inner Join Models on CarDetails.ModelID =Models.ModelID