
select * from PersonalInfo;

select * from AcademicInfo;

-- Create View 
create view Student_View as 
select P.StudentID,P.Name,P.Address,A.Course,A.Grade
from PersonalInfo P Inner join AcademicInfo A
on P.StudentID=A.StudentID;

--Onstead Of Update
create Trigger trg_InsteadOfUpdateStudent on Student_View
INSTEAD OF UPDATE
AS
BEGIN
 
 Update PersonalInfo
   set Name=I.Name,
       Address=I.Address
   from PersonalInfo P
   Inner join inserted I
   on P.StudentID=I.StudentID;

 Update AcademicInfo
   set Course=I.Course,
       Grade=I.Grade
   from AcademicInfo A
   Inner join inserted I
   on A.StudentID=I.StudentID;
   
END


-------------------

select * from Student_View;

UPDATE Student_View
SET Name = 'Karim Guendouz', Course = 'C#', Grade = 99
WHERE StudentID = 2;


--Check the Updates:
SELECT * FROM PersonalInfo WHERE StudentID = 2;
SELECT * FROM AcademicInfo WHERE StudentID = 2;


