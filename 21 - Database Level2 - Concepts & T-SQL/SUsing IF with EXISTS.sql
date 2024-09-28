
if(exists(select * from Employees where Name='John Smith'))
begin
   Print 'Yes , John Smith is there ';
end
else
begin
   Print 'No , John Smith is not there ';
end