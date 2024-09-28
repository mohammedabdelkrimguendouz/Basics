select * from CarDetails;

select * from CarDetails order by Year;

select * from CarDetails order by Make;

select * from CarDetails order by Fuel_Type_Name ,Year DESC;

select * from CarDetails order by NumDoors DESC,Year;

select * from CarDetails where Engine_Cylinders>4  order by Engine_Liter_Display;

select * from CarDetails order by Body,year DESC;

select * from CarDetails order by Drive_Type ,Engine_Liter_Display DESC,Make;

select * from CarDetails where Body='Sedan' order by NumDoors,Engine_Liter_Display DESC;

select * from CarDetails where Year>2010 order by Fuel_Type_Name ,Year DESC 

select * from CarDetails where Drive_Type='4WD' order by Engine ,Engine_Liter_Display DESC;