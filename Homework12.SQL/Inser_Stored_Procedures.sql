CREATE PROCEDURE InsertCustomer @Name varchar(50), @Email varchar (50)
AS
INSERT INTO Customer (Name,Email) Values (@Name,@Email)
GO;

CREATE PROCEDURE InsertEmployee @Name varchar(50), @Email varchar (50)
AS
INSERT INTO Employee(Name,Email) Values (@Name,@Email)
GO;

CREATE PROCEDURE InsertCategory @EmployeeId int, @Name varchar (50)
AS
INSERT INTO Employee(EmployeeId,Name) Values (@EmployeeId,@Name)
GO;

CREATE PROCEDURE InsertProduct @Name varchar (50), @CategoryId int, @Price decimal (7,2)
AS
INSERT INTO Product(Name,CategoryId,Price) Values (@CategoryId,@Name,@Price)
GO;

CREATE PROCEDURE InsertOrders @Number int, @Date date, @CustomerId int, @Status varchar(50)
AS
INSERT INTO Orders(Number,Date,CustomerId,Status) Values (@Number,@Date,@CustomerId,@Status,
GO;

CREATE PROCEDURE InsertOrderProduct @OrderId int, @ProductId int, @NumberOfProducts int
AS
INSERT INTO OrderProduct(OrderId,ProductId,NumberOfProducts) Values (@OrderId,@ProductId,@NumberOfProducts)
GO;



	