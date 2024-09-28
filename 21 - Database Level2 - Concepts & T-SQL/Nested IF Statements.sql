declare @Score int;
set @Score=60;

if(@Score>=90)
begin
  Print 'Grade A';
end
else
begin
   if(@Score>=80)
   begin
      Print 'Grade B';
   end
   else
   begin
      Print 'Grade C or lower';
   end


end