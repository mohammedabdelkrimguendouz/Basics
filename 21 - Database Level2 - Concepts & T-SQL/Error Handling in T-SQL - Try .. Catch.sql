
/* syntax 

BEGIN TRY
    -- T-SQL statements that may cause an error
END TRY
BEGIN CATCH
    -- Error handling code
END CATCH

*/

/*

ERROR_NUMBER(): Returns the error number.
ERROR_SEVERITY(): Returns the severity.
ERROR_STATE(): Returns the error state number.
ERROR_PROCEDURE(): Returns the name of the stored procedure or trigger where the error occurred.
ERROR_LINE(): Returns the line number where the error occurred.
ERROR_MESSAGE(): Returns the complete text of the error message.

*/

BEGIN TRY
    -- Insert a record into the Employees table
    INSERT INTO Employees3 (EmployeeID, Name, Position) VALUES (1, 'John Doe', 'Sales Manager');
    
    -- Attempt to insert a duplicate record which will cause an error
    INSERT INTO Employees3 (EmployeeID, Name, Position) VALUES (1, 'Jane Smith', 'Marketing Manager');
END TRY
BEGIN CATCH
    -- Handle the error
    PRINT 'An error occurred : ' + ERROR_MESSAGE();
	PRINT 'An error number : ' + cast( ERROR_NUMBER() as varchar);
	PRINT 'the severity : ' + cast( ERROR_SEVERITY() as varchar);
	PRINT 'the error state number : ' +  cast( ERROR_STATE() as varchar);
	PRINT 'name of the stored procedure or trigger where the error occurred : ' + ERROR_PROCEDURE();
	PRINT 'line number where the error occurred : ' + cast( ERROR_LINE() as varchar);
    -- Rollback the transaction if any
END CATCH






