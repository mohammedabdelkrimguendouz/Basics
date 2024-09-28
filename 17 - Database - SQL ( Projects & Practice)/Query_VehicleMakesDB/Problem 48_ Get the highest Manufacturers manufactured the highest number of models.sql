select top 1* from 
(
select   Makes.Make,COUNT(*) as NumberOfModels From Makes
Inner Join MakeModels on Makes.MakeID=MakeModels.MakeID
Group By Makes.Make
)R1
Order by NumberOfModels DESC



SELECT        Makes.Make, COUNT(*) AS NumberOfModels
		FROM            Makes INNER JOIN
								 MakeModels ON Makes.MakeID = MakeModels.MakeID
		GROUP BY Makes.Make

		having COUNT(*) = (

										select Max(NumberOfModels) as MaxNumberOfModels
										from
										(

												SELECT      MakeID, COUNT(*) AS NumberOfModels
												FROM       
																		 MakeModels
												GROUP BY MakeID
												
										) R1

		)