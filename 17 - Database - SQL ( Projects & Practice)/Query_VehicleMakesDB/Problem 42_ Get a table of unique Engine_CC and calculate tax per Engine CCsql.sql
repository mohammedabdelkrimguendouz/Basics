select  Distinct VehicleDetails.Engine_CC ,Tax=
CASE 
    When Engine_CC Between 0and 1000  then 100
	When Engine_CC Between 1001and 2000  then 200
	When Engine_CC Between 2001and 4000  then 300
	When Engine_CC Between 4001and 6000  then 400
	When Engine_CC >8000  then 600
	Else  0

END
from VehicleDetails 
order by Engine_CC

