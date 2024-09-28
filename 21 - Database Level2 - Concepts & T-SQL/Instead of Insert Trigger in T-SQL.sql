
select * from PersonalInfo;

select * from AcademicInfo;


--Onstead Of Insert
create Trigger trg_InsteadOfInsertStudent on Student_View
INSTEAD OF Insert
AS
BEGIN
 
 insert into PersonalInfo(StudentID,Name,Address)
 SELECT StudentID, Name,Address FROM inserted;

 insert into AcademicInfo(StudentID,Course,Grade)
 SELECT StudentID, Course,Grade FROM inserted;
 
END;


-------------------------------

select * from Student_View

INSERT INTO Student_View (StudentID, Name, Address, Course, Grade)
VALUES (4, 'mohammed', '789 Pine Rd', 'Data Base', 98);




--Verify the Insertions:

SELECT * FROM PersonalInfo WHERE StudentID = 4;
SELECT * FROM AcademicInfo WHERE StudentID = 4;


