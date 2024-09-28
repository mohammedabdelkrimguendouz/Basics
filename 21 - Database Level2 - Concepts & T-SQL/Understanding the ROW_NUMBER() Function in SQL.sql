
select * from Students order by grade desc

select StudentID,Name,Subject,grade,ROW_NUMBER() over (order by grade desc) as RowNum
from Students order by grade desc