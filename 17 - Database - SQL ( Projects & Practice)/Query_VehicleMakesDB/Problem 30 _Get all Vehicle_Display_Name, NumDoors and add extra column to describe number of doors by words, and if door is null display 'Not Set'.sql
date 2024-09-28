
select distinct numDoors From VehicleDetails;

select Vehicle_Display_Name ,NumDoors,
CASE 
    when NumDoors=0 then 'Zero Doors'
    when NumDoors=1 then 'One Doors'
    when NumDoors=2 then 'Tow Doors'
	when NumDoors=3 then 'Three Doors'
	when NumDoors=4 then 'Four Doors'
	when NumDoors=5 then 'Five Doors'
	when NumDoors=6 then 'Six Doors'
	when NumDoors=8 then 'Eight Doors'
	when NumDoors is Null Then 'Not Set'
	Else 'UnKnown' 
END as DoorDescrption
from VehicleDetails;