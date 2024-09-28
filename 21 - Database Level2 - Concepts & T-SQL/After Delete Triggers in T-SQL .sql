


create Trigger trg_AfterDeleteStudent on Students
AFTER Delete
as
begin
 INSERT INTO StudentDeleteLog(StudentID, Name, Subject, Grade)
 SELECT StudentID, Name, Subject, Grade FROM deleted;

end


-- Assuming there is a student with StudentID = 1 in the Students table


-- Deleting a student
DELETE FROM Students WHERE StudentID = 10;

select * from Students

-- Checking the delete log table
SELECT * FROM StudentDeleteLog;