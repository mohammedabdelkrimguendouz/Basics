declare @CustomerID int;
declare @TotalSpent Decimal(10,2);
declare @PointsEarned int;
declare @CurrentYear int=2023  ;/*Year(GetDate())*/



set @CustomerID=1;

select @TotalSpent =Sum(Amount) from Purchases 
Where CustomerID=@CustomerID And Year(PurchaseDate) =@CurrentYear;

set @PointsEarned=Cast( @TotalSpent/10 as int );

Update Customers 
set LoyaltyPoints=LoyaltyPoints+@PointsEarned
where CustomerID=@CustomerID

PRINT 'Loyalty Points Update for Customer ID: ' + CAST(@CustomerID AS VARCHAR);
PRINT 'Total Amount Spent in ' + CAST(@CurrentYear AS VARCHAR) + ': $' + CAST(@TotalSpent AS VARCHAR);
PRINT 'Loyalty Points Earned: ' + CAST(@PointsEarned AS VARCHAR);