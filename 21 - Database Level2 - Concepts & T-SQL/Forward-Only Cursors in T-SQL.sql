


Declare forward_only_cursor CURSOR STATIC /* or DUNAMIC */ FORWARD_ONLY FOR
select StudentID,Name,IsActive from Students;


OPEN forward_only_cursor;

Declare @StudentID int,@Name nvarchar(50),@IsActive bit;

FETCH NEXT FROM forward_only_cursor INTO @StudentID,@Name,@IsActive;

-- Enter a loop that will continue as long as the previous fetch was successful.
-- @@FETCH_STATUS returns 0 if the fetch was successful.
while (@@FETCH_STATUS=0)
BEGIN

 PRINT 'StudentID : '+Cast(@StudentID as Varchar)+' , Student Name : '+@Name+' , Is Active : '+Cast(@IsActive as Varchar);

 -- Fetch the next row of data from the cursor.
    -- The loop will continue until there are no more rows to fetch.
 FETCH NEXT FROM forward_only_cursor INTO @StudentID,@Name,@IsActive;

END

-- Once the loop is finished (no more rows to fetch), close the cursor.
-- Closing the cursor releases the current result set.
CLOSE forward_only_cursor;

-- Deallocate the cursor.
-- This step is important to free up resources used by the cursor.
DEALLOCATE forward_only_cursor;















