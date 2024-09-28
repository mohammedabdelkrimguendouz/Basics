
declare @Row int=1;
declare @Col int;
declare @Result int;
declare @RowString varchar(255)
declare @HeaderString varchar(255)

set @HeaderString=char(9);
set @Col=1;
while (@Col<=10)
begin
  set @HeaderString=@HeaderString+cast(@Col as varchar)+ char(9);
  set @Col+=1;
end
Print @HeaderString

WHILE @Row <= 10
BEGIN
    SET @Col = 1;
    SET @RowString = CAST(@Row AS VARCHAR) + CHAR(9); -- Start each row with the row number

    WHILE @Col <= 10
    BEGIN
        SET @RowString = @RowString + CAST( @Row * @Col AS VARCHAR) + CHAR(9); -- Append multiplication results
        SET @Col = @Col + 1;
    END

    PRINT @rowString; -- Print the row
    SET @row = @row + 1;
END