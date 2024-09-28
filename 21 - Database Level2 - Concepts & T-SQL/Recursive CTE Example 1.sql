


with Numbers as
(
  
  select 1 as Number

  Union ALL

  select Number+1 from Numbers where Number<10

)
select * from Numbers;
