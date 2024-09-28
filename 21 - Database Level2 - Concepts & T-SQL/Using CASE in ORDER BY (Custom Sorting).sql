SELECT *
FROM Sales
ORDER BY 
    CASE 
        WHEN SaleAmount >= 150 THEN 1
        ELSE 2
    END,SaleAmount desc;


use HR_Database

select * from Employees
order by
   case
     when MonthlySalary<1000 then 'D'
	 when MonthlySalary<2000 then 'C'
	 when MonthlySalary<3000 then 'B'
	 when MonthlySalary>3000 then 'A'
	 else 'Unknow'
   end ,MonthlySalary 