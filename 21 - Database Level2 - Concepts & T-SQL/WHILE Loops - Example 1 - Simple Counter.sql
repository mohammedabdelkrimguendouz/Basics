
declare @Counter int =1;


while @Counter<=5
begin
 Print 'Count : '+cast(@Counter as varchar)
 set @Counter+=1;
end

print ' '
Print 'Reverce Counter '

while @Counter>=1
begin
 Print 'Count : '+cast(@Counter as varchar)
 set @Counter-=1;
end
