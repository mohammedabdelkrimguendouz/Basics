select * from CarDetails;

select Make,model,Year from CarDetails;

select distinct Make from CarDetails;/* dont reapet*/

select * from CarDetails where Year>=2020;

select Make,Model,Year,engine_Liter_Display from CarDetails where NumDoors>4;

select Make,Model,Year from CarDetails order by Year Desc;

select Make,Total_Cars=count(*) from CarDetails Group by Make;

select Make,Model,Year from CarDetails where engine_Liter_Display>
(
select AVG(engine_Liter_Display) From CarDetails
);

Select *,Age=YEAR(GETDATE())-Year From CarDetails; /* age cars */

select Make,Model,Year,Fuel_Type_Name from CarDetails where Fuel_Type_Name='Electric' order by Year;

select Make,Model from CarDetails where Model like 'c%' and NumDoors=4;

select Make,Model,Year,engine_Liter_Display from CarDetails where engine_Liter_Display between 2.0 and 3.5;

