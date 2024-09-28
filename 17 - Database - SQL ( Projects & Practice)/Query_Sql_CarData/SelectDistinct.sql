
select * from CarDetails;

select Distinct  Make from CarDetails;

select Distinct Year from CarDetails;

select Distinct Fuel_Type_Name from CarDetails;

select Distinct model,Body From CarDetails;

select Distinct Year,Drive_Type from CarDetails;


select Distinct  Make,Model,Year from CarDetails;

select Distinct Aspiration from CarDetails Where Fuel_Type_Name='DIESEL';

select Distinct Region From CarDetails;

select  Count(Distinct Make) as Number_Make_Diff from CarDetails; /* number make cars  differont */

select count(Distinct Body) as Number_Body_Diff_Toyota From CarDetails where Make='TOYOTA';