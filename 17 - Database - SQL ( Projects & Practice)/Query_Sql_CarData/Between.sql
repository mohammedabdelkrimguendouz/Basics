select * from CarDetails;

select * from CarDetails where Year between 2010 and 2020;

select * from CarDetails where Engine_Liter_Display between 2.0 and 3.0;

select * from CarDetails where Engine_Cylinders between 4 and 8;

select * from CarDetails where Body='Sedan' and NumDoors between 2 and 4;

select * from CarDetails where Fuel_Type_Name='DIESEL' and Year between 2005 and 2015;

select * from CarDetails where Engine_CC between 1500 and 2500 and Year between 2000 and 2010;

select * from CarDetails where Drive_Type in ('4WD','FWD') and Year between 2005 and 2015 order by Year ;

select * from CarDetails where Body in('SUV','Truck') and Engine_Cylinders between 4 and 6 and  Year between 2010 and 2020;

select * from CarDetails where Engine_CC between 2000 and 3000 and Drive_Type='4WD' and  Year between 2000 and 2015;