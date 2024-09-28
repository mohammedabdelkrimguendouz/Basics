
--alter table Employees
--RENAME column Gendor to Gender

exec sp_rename 'employees.Gendor','Gender','COLUMN';
