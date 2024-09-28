
create Trigger trg_InsteadOfDeleteStudent on Students
INSTEAD OF DELETE
AS
BEGIN
 
 Update Students
   set IsActive=0 
   from Students S
   Inner join deleted D
   on S.StudentID=D.StudentID
   
END


-----------------------------------------------

-- Assuming there is a student with StudentID = 3

select * from Students

-- Attempting to delete a student
DELETE FROM Students WHERE StudentID = 3;


-- Checking the status of the student record
SELECT StudentID, Name, IsActive FROM Students WHERE StudentID = 3;










