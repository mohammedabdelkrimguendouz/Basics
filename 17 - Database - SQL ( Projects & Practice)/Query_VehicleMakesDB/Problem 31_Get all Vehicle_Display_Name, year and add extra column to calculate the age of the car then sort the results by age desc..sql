select Vehicle_Display_Name,Year,YEAR(GETDATE())-Year as Age  from VehicleDetails 
Order by Age DESC