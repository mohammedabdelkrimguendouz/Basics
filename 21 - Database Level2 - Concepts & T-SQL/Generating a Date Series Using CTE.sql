

DECLARE @StartDate DATE = '2024-01-01'; -- Start of the date range
DECLARE @EndDate DATE = '2024-01-31';   -- End of the date range


with DateSeries as
(
 select @StartDate as DateValue

 Union All

 select DATEADD(day,1,DateValue) from DateSeries where DateValue<@EndDate

)
select * from DateSeries;