select * ,
Bouns= case 
           when Department='Sales' then
		     case
			    when PerformanceRating >90 then Salary*0.15
				when PerformanceRating between 75 and 90 then Salary*0.10
				else Salary*0.05
			 end

			 when Department='HR' then
		     case
			    when PerformanceRating >90 then Salary*0.10
				when PerformanceRating between 75 and 90 then Salary*0.08
				else Salary*0.04
			 end

			 else 
			 case
			    when PerformanceRating >90 then Salary*0.08
				when PerformanceRating between 75 and 90 then Salary*0.06
				else Salary*0.03
			 end

	   end
from Employees2;