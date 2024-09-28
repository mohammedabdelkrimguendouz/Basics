

create Trigger trg_AfterUpdateStudent on Students
AFTER UPDATE
as
begin

IF UPDATE(Grade)
    BEGIN
        INSERT INTO StudentUpdateLog(StudentID, OldGrade, NewGrade)
        SELECT i.StudentID, d.Grade AS OldGrade, i.Grade AS NewGrade
        FROM inserted i
        INNER JOIN deleted d ON i.StudentID = d.StudentID;
    END
end

------------------------------
-- Updating the grade of a student
UPDATE Students
SET Grade = 90
WHERE StudentID = 7;


-- Checking the log table
SELECT * FROM StudentUpdateLog;
SELECT * FROM Students;

