select 
   StudentID ,Name,Subject,Grade,
   DENSE_RANK() over (Partition By Subject order by Grade Desc) as GradeRank
   FROM 
    Students;

	