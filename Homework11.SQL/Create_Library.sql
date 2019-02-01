CREATE TABLE Author
(
	AuthorID int NOT NULL PRIMARY KEY identity(1,1),
	FirstName NVarchar(150) NOT NULL,
	LastName nVARCHAR(150) NOT NULL,
	BirthDate dateTime Null
)

CREATE TABLE PUBLISHER --Ex1-1
(
 PublisherId int NOT NULL PRIMARY KEY IDENTITY(1,1),
 Name nVarchar(150) NOT NULL
)

CREATE TABLE Book
(
	BookId int NOT NULL PRIMARY KEY IDENTITY(1,1),
	Title nVARCHAR(150) NOT NULL,
	PublisherId int NOT NULL,
	Year int NULL,
	Price decimal NOT NULL,
	HardCover bit NUll, --Ex1-2
	CONSTRAINT FK_Publisher_Book_PublisherId FOREIGN KEY (PublisherId) REFERENCES Publisher(PublisherId)
)

CREATE TABLE BookAuthor
(
	BookAuthorId int NOT NULL PRIMARY KEY identity(1,1),
	BookId int NOT NULL,
	AuthorId int NOT NULL,
	CONSTRAINT FK_Book_BookAuthor_BookID FOREIGN KEY (BookID) REFERENCES Book(BookID),
	CONSTRAINT FK_Author_BookAuthor_AuthorIdID FOREIGN KEY (AuthorId) REFERENCES Author(AuthorId)

)

CREATE TABLE Category
(
	CategoryId int NOT NULL PRIMARY KEY identity (1,1),
	Name nVarchar(150) NOT NULL
)

CREATE TABLE BookCategory
(
	BookCategoryId int NOT NULL PRIMARY KEY identity (1,1),
	BookId int NOT NULL,
	CategoryId int NOT NULL,
	CONSTRAINT FK_Book_BookCategory_BookID FOREIGN KEY (BookID) REFERENCES Book(BookID),
	CONSTRAINT FK_Category_BookCategory_CategoryId FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId)
)

CREATE TABLE Address
(
	AddressId int NOT NULL PRIMARY KEY identity(1,1),
	Street nVarchar (200) NOT NULL,
	BuildingNumber int NOT NULL,
	BuildingName nVarchar (50) NULL,
	EntranceNumber int NULL,
	Floor int NULL,
	ApartmentNumber int NOT NULL,
	City nVarchar (100) NOT NULL,
	PostalCode int NULL,
	Country nVarchar (50) NOT NULL,
	OtherDetails nVarchar (150) NULL
)

CREATE TABLE Library
(
	LibraryId int NOT NULL PRIMARY KEY identity(1,1),
	Name nVarchar(100) NOT NULL,
	AddressId int NOT NULL,
	CONSTRAINT FK_Address_Library_AddressID FOREIGN KEY (AddressID) REFERENCES Address(AddressID),
	
)

CREATE TABLE BookLibrary
(
	BookLibraryId int NOT NULL PRIMARY KEY identity(1,1),
	LibraryId int NOT NULL,
	BookId int NOT NULL,
	Quantity int NOT NULL,
	CONSTRAINT FK_Book_BookLibrary_BookID FOREIGN KEY (BookID) REFERENCES Book(BookID),
	CONSTRAINT FK_Library_BookLibrary_LibraryId FOREIGN KEY (LibraryId) REFERENCES Library(LibraryId)
)

CREATE TABLE Member 
(
	MemberID INT NOT NULL PRIMARY KEY identity(1,1),
	FirstName nVARCHAR(50) NOT NULL,
	LastName nVARCHAR(50) NOT NULL,
	AddressID int NOT NULL,
	Gender nVARCHAR(20) NOT NULL,
	PhoneNumber nVARCHAR(50),
	EmailAddress nVARCHAR(100),
	CONSTRAINT FK_Member_Address_AddressID FOREIGN KEY (AddressID) REFERENCES Address(AddressID),
	
)

CREATE TABLE LibraryMember --EX1-3
(
	LibraryMemberId int NOT NULL PRIMARY Key identity (1,1),
	MemberID INT NOT NULL,
	LibraryId int NOT NULL,
	PermitNumber nVARCHAR(30)NULL, --EX1-4
	CONSTRAINT FK_LibraryMember_Member_MemberID FOREIGN KEY (MemberID) REFERENCES Member(MemberID),
	CONSTRAINT FK_LibraryMember_Library_LibraryID FOREIGN KEY (LibraryID) REFERENCES Library(LibraryID),

)

CREATE TABLE Request
(
	RequestID INT NOT NULL PRIMARY KEY identity(1,1),
	MemberID INT NOT NULL,
	BookID INT NOT NULL,
	LibraryID INT NOT NULL, --Ex1-5
	DateRequested DATE NOT NULL,
	DateReturned DATE,
	CONSTRAINT FK_Request_Book_BookID FOREIGN KEY (BookID) REFERENCES Book(BookID),
	CONSTRAINT FK_Request_Member_MemberID FOREIGN KEY (MemberID) REFERENCES Member(MemberID),
	CONSTRAINT FK_Request_Library_LibraryID FOREIGN KEY (LibraryID) REFERENCES Library(LibraryID), --Ex1-5
)





