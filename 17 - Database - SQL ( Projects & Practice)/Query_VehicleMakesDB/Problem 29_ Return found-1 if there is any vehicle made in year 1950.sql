select Found=1 
where exists
(
  select top 1 R='Y' from VehicleDetails
  Where Year=1950
)