
select * from 
(
select Vehicle_Display_Name,Year,YEAR(GETDATE())-Year as Age  from VehicleDetails 
)R1
Where Age between 15 and 20
