
select PerformanceCategory,
      Count(*) as NumberOfEmplyees,
	  Avg(Salary) as AvargeSalary

	  from (
	    select Name ,Salary ,case 
		when PerformanceRating >80 then 'high'
		when PerformanceRating  between 60 and 80  then 'Medium'
		else 'Low'
		end as PerformanceCategory

		from Employees2) as PerformanceTable
group by PerformanceCategory 

