Select * from CarDetails;

select 'Exist Cars from 2020' as Result where
EXISTS
(
select * from CarDetails where year =2020
);

