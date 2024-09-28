select top 3 Makes.Make,COUNT(*) as NumberOfModels From Makes
Inner Join MakeModels on Makes.MakeID=MakeModels.MakeID
Group By Makes.Make
Order By NumberOfModels DESC