

Declare static_cursor CURSOR STATIC FOR
select StudentID,Name,Grade from Students;


OPEN static_cursor;

Declare @StudentID int,@Name nvarchar(50),@Grade int;

FETCH NEXT FROM static_cursor INTO @StudentID,@Name,@Grade;

-- Enter a loop that will continue as long as the previous fetch was successful.
-- @@FETCH_STATUS returns 0 if the fetch was successful.
while (@@FETCH_STATUS=0)
BEGIN

 PRINT 'StudentID : '+Cast(@StudentID as Varchar)+' , Student Name : '+@Name+' , Student Grade : '+Cast(@Grade as Varchar);

 -- Fetch the next row of data from the cursor.
    -- The loop will continue until there are no more rows to fetch.
 FETCH NEXT FROM static_cursor INTO @StudentID,@Name,@Grade;

END

-- Once the loop is finished (no more rows to fetch), close the cursor.
-- Closing the cursor releases the current result set.
CLOSE static_cursor;

-- Deallocate the cursor.
-- This step is important to free up resources used by the cursor.
DEALLOCATE static_cursor;
