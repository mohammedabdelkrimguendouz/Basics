select * from CarDetails;

select * from CarDetails where Make in ('TOYOTA','HONDA','Ford')

select * from CarDetails where Year in (2010,2015,2020);

select * from CarDetails where Body in ('Coupe','Sedan','Hatchback') and NumDoors=4;

select * from CarDetails where Fuel_Type_Name in ('DIESEL','Petrol') and Engine_Liter_Display>2.0;

select * from CarDetails where Drive_Type in ('4 X 4','4 X 2') and  Make not in('Peugeot','Fait','Renault');

select * from CarDetails where Year in (2010,2015,2005) and Engine_Liter_Display in (2.0,2.5,1.5);

select * from CarDetails where Fuel_Type_Name in('Electric','Hybrid') and Year>2018;

