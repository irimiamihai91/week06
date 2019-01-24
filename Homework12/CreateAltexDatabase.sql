CREATE TABLE Customer
(
	CustomerId int NOT NULL PRIMARY KEY IDENTITY(1,1),
	Name varchar (50) NOT NULL,
	Email varchar(50),
)


CREATE TABLE Employee
(
	EmployeeId int NOT NULL PRIMARY KEY IDENTITY(1,1),
	Name varchar (50) NOT NULL,
	Email varchar(50) CHECK (Email like '%@altex.com')
)


CREATE TABLE Category
(
	CategoryId int NOT NULL PRIMARY KEY IDENTITY(1,1),
	EmployeeId int NOT NULL,
	Name varchar (50) NOT NULL CHECK(Name = upper(Name)),
	Constraint FK_Employee_Category_EmployeeId Foreign Key (EmployeeId) References Employee(EmployeeId)
)


CREATE TABLE Product
(
	ProductId int NOT NULL PRIMARY KEY IDENTITY(1,1),
	CategoryId int NOT NULL,
	Name varchar(50) NOT NULL,
	Description varchar (250),
	Price decimal(7,2) NOT NULL CHECK (Price>=10),
	Constraint FK_Category_Product_CategoryId Foreign Key (CategoryId) References Category(CategoryId)
)


CREATE TABLE Orders
(
	OrderId int NOT NULL PRIMARY KEY IDENTITY(1,1),
	Number int  NOT NULL,
	Date date NOT NULL,
	CustomerId int NOT NULL,
	Status varchar(50) CHECK (Status IN ('Processing','Aproved','Complete','Cancel')),
	TotalPrice decimal(10,2),
	Unique(Number),
	Constraint FK_Customer_Orders_CustomerId Foreign Key (CustomerId) References Customer(CustomerId)
)


CREATE TABLE OrderProduct
(
	OrderId int NOT NULL,
	ProductId int NOT NULL,
	NumberOfProducts int NOT NULL,
	Constraint PK_OrderProduct PRIMARY KEY(OrderId,ProductId),
	Constraint FK_Customer_OrderProduct_OrderId Foreign Key (OrderId ) References Orders(OrderId ),
	Constraint FK_Customer_OrderProduct_ProductId Foreign Key (ProductId ) References Product(ProductId )
)










