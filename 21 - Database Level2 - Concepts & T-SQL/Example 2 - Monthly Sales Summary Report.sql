
Declare @Year Int;
Declare @Month Int;
Declare @TotalSales Decimal(10,2);
Declare @TotalTranactions Int;
Declare @AvargeSales Decimal(10,2);

set @Year=2023;
set @Month=6;

select @TotalSales=Sum(SaleAmount) from Sales 
Where Year(SaleDate)=@Year And Month(SaleDate)=@Month;


select @TotalTranactions=Count(*) from Sales 
Where Year(SaleDate)=@Year And Month(SaleDate)=@Month;

set @AvargeSales=@TotalSales/@TotalTranactions;

Print 'Monthly Sales Summary Report ' ;
Print 'Year : '+ Cast(@Year as VarChar ) + ' , ' + 'Month : '+ Cast(@Month as VarChar );
Print 'Total Sales : ' +Cast(@TotalSales as VarChar);
Print 'Total Tranactions : ' +Cast(@TotalTranactions as VarChar);
Print 'Avarge Sale Value : ' +Cast(@AvargeSales as VarChar);
