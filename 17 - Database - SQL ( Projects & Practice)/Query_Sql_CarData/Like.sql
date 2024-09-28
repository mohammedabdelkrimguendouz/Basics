select * From CarDetails;

select * From CarDetails where Make like 'A%';


select * From CarDetails where Model like '%a';

select * From CarDetails where Make like '%Ford%';

select * From CarDetails where Model like '_n%';


select * From CarDetails where Make like '___';


select * From CarDetails where Model like 'C%s';


select * From CarDetails where Model like '%eco_';


select * From CarDetails where Model not like 'A%' and Model Not like '%Z';

