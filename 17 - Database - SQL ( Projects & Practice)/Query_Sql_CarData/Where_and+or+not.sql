select * from CarDetails;

select * from CarDetails where Make='TOYOTA' and Year=2015;

select * from CarDetails where Make='Ford' and NumDoors=4 and Body='Sedan';

select * from CarDetails Where Year=2018 or Year =2019;

select * from CarDetails Where (Make='Chevrolet' or Make='Honda')and Drive_Type='4 X 4'; 

select * from CarDetails where not Make='BMW';

select * from CarDetails where not Year=2020 and Engine_Cylinders>6;

select * from CarDetails where (Make='Audi' and not Year=2014)or (Make='TOYOTA' and  Year=2015)

select * from CarDetails where  (Year>2015 and (Drive_Type='4 X 4' or  Drive_Type='4 X 6')and not Make='Fiat');

select * from CarDetails where Fuel_Type_Name='DIESEL' and (NumDoors=4 or NumDoors=5) and not Year=2022;

select * from CarDetails where (Body='Coupe' or Body='Sedan')and Engine_Liter_Display>2.0 and not Fuel_Type_Name='Petrol'