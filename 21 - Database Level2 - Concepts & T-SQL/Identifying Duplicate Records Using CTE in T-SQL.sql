

with DublicateEmails as
(
select Email,Count(*) as DuplicateEmail
from Contacts 
group by Email Having Count(*)>1

)
select C.ContactID,C.Name,C.Email
from Contacts C
Inner join DublicateEmails De on 
C.Email=De.Email;