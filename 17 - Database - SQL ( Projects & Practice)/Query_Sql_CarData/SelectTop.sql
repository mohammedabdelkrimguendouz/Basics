select * from CarDetails;

select top 10 * from CarDetails;

select   DISTINCT top 5 Make from CarDetails  ;

select top 3 Model From CarDetails where Year=2020;


select top 10 Make,model,engine_Liter_Display from CarDetails order by engine_Liter_Display Desc ;

select top 5 * from CarDetails where Drive_Type='4 X 4' order by Year Desc;

select top 8 Make,model,Year,NumDoors from CarDetails order by NumDoors Desc;

select top 10 percent * from CarDetails order by Year DESC; 

select top 20 Percent Make,model,Year,Engine_CC from CarDetails order by Engine_CC DESC;

