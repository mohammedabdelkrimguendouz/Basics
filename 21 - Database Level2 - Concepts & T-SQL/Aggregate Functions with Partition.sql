SELECT 
    StudentID, 
    Name, 
    Subject, 
    Grade,
    AVG(Grade) OVER (PARTITION BY Subject) AS SubjectAvgGrade,
    SUM(Grade) OVER (PARTITION BY Subject) AS SubjectTotalGrade
FROM 
    Students
ORDER BY Subject;




SELECT 
    Subject, 
    AVG(Grade) SubjectAvgGrade,
    SUM(Grade)  SubjectTotalGrade
FROM 
    Students
Group BY Subject;
