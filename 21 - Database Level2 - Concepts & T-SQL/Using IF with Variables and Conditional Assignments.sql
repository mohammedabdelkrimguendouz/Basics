DECLARE @age INT;
SET @age = 25;


IF @age >= 18
BEGIN
    PRINT 'Adult'
END
ELSE
BEGIN
    PRINT 'Minor'
END

DECLARE @max INT;
Declare @a int, @b int;
set @a=20;
set @b=10;


IF @a > @b
    SET @max = @a
ELSE
    SET @max = @b

Print @max;