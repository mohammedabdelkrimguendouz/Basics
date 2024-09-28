
create Trigger trg_AfterInsertStudent on Students
AFTER INSERT
as
begin
 INSERT INTO StudentInsertLog(StudentID, Name, Subject, Grade)
 SELECT StudentID, Name, Subject, Grade FROM inserted;

end

-----------------------------------
-- Inserting a new student
INSERT INTO Students (StudentID, Name, Subject, Grade)
VALUES (10, 'John Doe', 'Mathematics', 85);


-- Checking the log table
SELECT * FROM StudentInsertLog;