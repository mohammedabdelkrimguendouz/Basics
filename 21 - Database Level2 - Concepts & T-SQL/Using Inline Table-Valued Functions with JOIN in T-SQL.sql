
select  S.StudentID ,S.Name as StudentName ,T.Name as  TeacherName,S.Grade
from GetStudentsBySubject('Math') S
 Join Teachers T
On S.Subject=T.Subject
where S.Grade<90