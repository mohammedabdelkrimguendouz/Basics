
declare @Row int =1;
declare @Col int;

while(@Row<=10)
begin
   set @Col=1;
   Print ' Table Multiplication  : ' +Cast(@Row as varchar); 
   while(@Col<=10)
   begin
     Print Cast(@Row as varchar) +' X '+ Cast(@Col as varchar) +' = ' + cast (@Col*@Row as varchar);
	 set @Col+=1;
   end
   
   set @Row+=1;
   print ' '
end