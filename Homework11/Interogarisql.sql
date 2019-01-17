--Interogari
--1
SELECT NAME
FROM Library
WHERE AddressId IN (SELECT AddressId FROM Address WHERE CITY='Iasi')
go

--2
SELECT MemberId AS Id, CONCAT(FirstName ,' ',LastName) AS Name
from Member
WHERE MemberID IN (SELECT MemberID FROM LibraryMember 
WHERE LibraryId IN (SELECT LibraryId FROM Library WHERE NAME LIKE '%Asachi'))
go

--3 
select Title
from 
Book b Inner Join BookCategory c On b.BookId = c.BookId
Inner Join Category d On d.CategoryId = c.CategoryId 
Left join BookLibrary e On  b.BookId = e.BookId
Left Join Library f On e.LibraryId = f.LibraryId
WHERE d.Name = 'Fantasy' and b.Title like 'U%' and f.Name = 'Biblioteca Centrala Universitara'

--4

select Title 
From Book b Inner Join Request c On b.BookId = c.BookId
Left Join Member d On c.MemberID = d.MemberID
Left Join Library e On c.LibraryID = e.LibraryId
Where d.FirstName = 'Daniel' and D.LastName = 'Ionescu' 
and e.Name In( 'Biblioteca Centrala Universitara')
and c.DateReturned IS NULL

--5
Select Count(BookId) As Number, Name
From Category c
Left Join BookCategory bc On c.CategoryId = bc.CategoryId
Group By Name

--6

Select Distinct Title,a.FirstName, a.LastName,b.Price
FROM Book b
Inner Join BookAuthor ba On b.BookId = ba.BookId
Inner Join Author a On ba.AuthorId = a.AuthorID
Inner Join Request r On b.BookId = r.BookID
Left Join Member m On r.MemberID = m.MemberID
Where r.DateRequested IS NOT Null and m.FirstName = 'Mihai' and m.LastName= 'Popescu' and r.LibraryID = 1
Order By Price Desc

--7

Select Sum(Quantity) as SaledCopies,b.Title
From Book b
Left Join BookLibrary bl ON b.BookId = bl.BookId
WHERE LibraryId IN (1,2) and b.Title = 'Fluturi'
GROUP BY Title









 

