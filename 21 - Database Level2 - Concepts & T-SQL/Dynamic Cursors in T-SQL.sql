


Declare dynamic_cursor CURSOR DYNAMIC FOR
select StudentID,Name,Subject from Students;


OPEN dynamic_cursor;

Declare @StudentID int,@Name nvarchar(50),@Subject nvarchar(50);

FETCH NEXT FROM dynamic_cursor INTO @StudentID,@Name,@Subject;

-- Enter a loop that will continue as long as the previous fetch was successful.
-- @@FETCH_STATUS returns 0 if the fetch was successful.
while (@@FETCH_STATUS=0)
BEGIN

 PRINT 'StudentID : '+Cast(@StudentID as Varchar)+' , Student Name : '+@Name+' , Subject : '+@Subject;

 -- Fetch the next row of data from the cursor.
    -- The loop will continue until there are no more rows to fetch.
 FETCH NEXT FROM dynamic_cursor INTO @StudentID,@Name,@Subject;

END

-- Once the loop is finished (no more rows to fetch), close the cursor.
-- Closing the cursor releases the current result set.
CLOSE dynamic_cursor;

-- Deallocate the cursor.
-- This step is important to free up resources used by the cursor.
DEALLOCATE dynamic_cursor;
