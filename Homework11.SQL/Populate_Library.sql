

INSERT INTO Address (Street, BuildingNumber, ApartmentNumber, City, PostalCode, Country) Values ('Pacurari', 4, 0, 'Iasi', 700511, 'Iasi' );
INSERT INTO Address (Street, BuildingNumber, BuildingName,EntranceNumber,Floor,ApartmentNumber,City, Country) Values ('Pacurari', 581, '4B',2,2,12,'Iasi', 'Iasi' );
INSERT INTO Address (Street, BuildingNumber, BuildingName,EntranceNumber,Floor,ApartmentNumber,City, Country) Values ('Independentei', 128, '2',1,1,5,'Iasi', 'Iasi' );
INSERT INTO Address (Street, BuildingNumber, ApartmentNumber, City, Country) Values ('Petre Tutea', 9, 0, 'Iasi', 'Iasi' );
INSERT INTO Address (Street, BuildingNumber, ApartmentNumber, City, Country) Values ('Clinicilor', 2, 0, 'Cluj Napoca', 'Cluj Napoca' );


INSERT INTO Library (Name, AddressId) values ('Biblioteca Centrala Universitara', 1);
INSERT INTO Library (Name, AddressId) values ('Gheorghe Asachi', 4);
INSERT INTO Library (Name, AddressId) values ('Biblioteca Centrala Universitara', 5);



INSERT INTO Category (Name) VALUES ('Clasici');
INSERT INTO Category (Name) VALUES ('Fictiune');
INSERT INTO Category (Name) VALUES ('Fantasy');
INSERT INTO Category (Name) VALUES ('Thriller');
INSERT INTO Category (Name) VALUES ('Crime');
INSERT INTO Category (Name) VALUES ('Aventura');


INSERT INTO Publisher (Name) VALUES ('Polirom');
INSERT INTO Publisher (Name) VALUES ('For you');
INSERT INTO Publisher (Name) VALUES ('Litera');
INSERT INTO Publisher (Name) VALUES ('Nemira');
INSERT INTO Publisher (Name) VALUES ('Rao');
INSERT INTO Publisher (Name) VALUES ('Litera');
INSERT INTO Publisher (Name) VALUES ('Trei');
INSERT INTO Publisher (Name) VALUES ('Asa');
INSERT INTO Publisher (Name) VALUES ('Art');



INSERT INTO Author(FirstName, LastName,BirthDate) VALUES ('J.D.','Salinger','1991-11-11');
INSERT INTO Author(FirstName, LastName,BirthDate) VALUES ('Irina','Binder','1995-10-21');
INSERT INTO Author(FirstName, LastName,BirthDate) VALUES ('Mihai','Eminescu','1980-10-11');
INSERT INTO Author(FirstName, LastName,BirthDate)VALUES ('Oscar','Wilde','1991-11-11');
INSERT INTO Author(FirstName, LastName,BirthDate) VALUES ('George R. R. ','Martin','1981-11-11');
INSERT INTO Author(FirstName, LastName,BirthDate) VALUES ('Patrick','Rothfuss','1988-11-11');
INSERT INTO Author(FirstName, LastName,BirthDate) VALUES ('Deborah','Harkness','1994-11-11');
INSERT INTO Author(FirstName, LastName,BirthDate) VALUES ('Stephanie','Meyer','1971-11-11');
INSERT INTO Author(FirstName, LastName) VALUES ('Mihail ','Sadoveanu');
INSERT INTO Author(FirstName, LastName) VALUES ('J. K. ','Rowling');
INSERT INTO Author(FirstName, LastName) VALUES ('Joe ','Abercrombie');




INSERT INTO Book(Title, PublisherId, Year, Price, HardCover) 
	VALUES ('De veghe in lanul de secara’',1,2016,17,0);
INSERT INTO Book(Title, PublisherId, Year, Price, HardCover) 
	VALUES ('Fluturi',2,2016,13,0);
INSERT INTO Book(Title, PublisherId, Year, Price, HardCover) 
	VALUES ('Proza',3,2011,8,1);
INSERT INTO Book(Title, PublisherId, Year, Price, HardCover) 
	VALUES ('Portretul lui Dorian Grey',1,2013,18,0);
INSERT INTO Book(Title, PublisherId, Year, Price, HardCover) 
	VALUES ('Urzeala tronurilor',4,2017,30,0);
INSERT INTO Book(Title, PublisherId, Year, Price, HardCover) 
	VALUES ('Numele vantului',5,2017,35,0);
INSERT INTO Book(Title, PublisherId, Year, Price, HardCover) 
	VALUES ('Cartea vietii',6,2017,24,0);
INSERT INTO Book(Title, PublisherId, Year, Price, HardCover) 
	VALUES ('Chimista’',7,2016,33,0);
INSERT INTO Book(Title, PublisherId, Year, Price, HardCover) 
	VALUES ('Baltagul',8,2014,22,0);
INSERT INTO Book(Title, PublisherId, Year, Price, HardCover) 
	VALUES ('Harry Potter vol. 5',9,2017,64,0);
INSERT INTO Book(Title, PublisherId, Year, Price, HardCover) 
	VALUES ('Puterea armelor',4,2017,35,0);


INSERT INTO BookCategory (BookId, CategoryId) VALUES (1,1);
INSERT INTO BookCategory (BookId, CategoryId) VALUES (2,2);
INSERT INTO BookCategory (BookId, CategoryId) VALUES (3,1);
INSERT INTO BookCategory (BookId, CategoryId) VALUES (4,1);
INSERT INTO BookCategory (BookId, CategoryId) VALUES (5,3);
INSERT INTO BookCategory (BookId, CategoryId) VALUES (6,3);
INSERT INTO BookCategory (BookId, CategoryId) VALUES (7,3);
INSERT INTO BookCategory (BookId, CategoryId) VALUES (7,5);
INSERT INTO BookCategory (BookId, CategoryId) VALUES (9,1);
INSERT INTO BookCategory (BookId, CategoryId) VALUES (10,6);
INSERT INTO BookCategory (BookId, CategoryId) VALUES (11,6);


INSERT INTO BookAuthor(BookId, AuthorId) VALUES (1,1);
INSERT INTO BookAuthor(BookId, AuthorId) VALUES (2,2);
INSERT INTO BookAuthor(BookId, AuthorId) VALUES (3,3);
INSERT INTO BookAuthor(BookId, AuthorId) VALUES (4,4);
INSERT INTO BookAuthor(BookId, AuthorId) VALUES (5,5);
INSERT INTO BookAuthor(BookId, AuthorId) VALUES (6,6);
INSERT INTO BookAuthor(BookId, AuthorId) VALUES (7,7);
INSERT INTO BookAuthor(BookId, AuthorId) VALUES (8,8);
INSERT INTO BookAuthor(BookId, AuthorId) VALUES (9,9);
INSERT INTO BookAuthor(BookId, AuthorId) VALUES (10,10);
INSERT INTO BookAuthor(BookId, AuthorId) VALUES (11,11);



INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (1,1,5);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (1,2,3);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (1,3,10);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (1,4,6);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (1,5,25);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (1,6,10);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (1,7,4);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (1,8,2);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (2,9,5);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (2,10,8);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (2,11,4);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (2,2,14);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (2,3,7);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (3,11,3);
INSERT INTO BookLibrary(LibraryId,BookId,Quantity) VALUES (3,2,5);


INSERT INTO Member(FirstName, LastName, AddressID, Gender, PhoneNumber, EmailAddress) VALUES ('Daniel','Ionescu',2,'Male','0728406394', 'daniel.popescu@gmail.com');
INSERT INTO Member(FirstName, LastName, AddressID, Gender, PhoneNumber, EmailAddress) VALUES ('Mihai','Popescu',3,'Male','0749281504', ' mihai.popescu@yahoo.com');

INSERT INTO LibraryMember(MemberID,LibraryId,PermitNumber) VALUES (1,1,'AGX-40194');
INSERT INTO LibraryMember(MemberID,LibraryId,PermitNumber) VALUES (2,1,'BCS-40329');
INSERT INTO LibraryMember(MemberID,LibraryId,PermitNumber) VALUES (1,2,' FME-23043');



INSERT INTO Request(MemberID,BookID,LibraryId,DateRequested,DateReturned) VALUES (1,2,1,'2017-05-15','2017-05-21');
INSERT INTO Request(MemberID,BookID,LibraryId,DateRequested,DateReturned) VALUES (1,6,1,'2017-09-21','2017-09-30');
INSERT INTO Request(MemberID,BookID,LibraryId,DateRequested) VALUES (1,8,1,'2017-12-18 ');
INSERT INTO Request(MemberID,BookID,LibraryId,DateRequested) VALUES (2,5,1,'2017-03-11');
INSERT INTO Request(MemberID,BookID,LibraryId,DateRequested,DateReturned) VALUES (2,8,1,'2017-06-14','2017-06-24');
INSERT INTO Request(MemberID,BookID,LibraryId,DateRequested,DateReturned) VALUES (1,11,2,'2017-08-12','2017-08-21');
INSERT INTO Request(MemberID,BookID,LibraryId,DateRequested) VALUES (1,9,2,'2017-10-13');

