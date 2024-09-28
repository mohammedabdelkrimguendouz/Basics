

alter FUNCTION GetStudentsBySubject(@Subject NVARCHAR(50))
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM Students
    WHERE Subject = @Subject
)
----------------------------------

-- Example 1: Select all students studying Math
SELECT *
FROM GetStudentsBySubject('Math')


-- Example 2: Get the average grade of students studying Science
SELECT AVG(Grade) as AverageGrade
FROM GetStudentsBySubject('Science')





