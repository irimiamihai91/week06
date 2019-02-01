--4.	Afisati toate produsele.
Create View ShowProducts
AS
SELECT * FROM Product
GO;

SELECT * FROM ShowProducts

--5.Afisati toti clientii care au in continutul email-ului @wantsome.com.

SELECT * 
FROM Customer
Where Email like '%wantsome.com'

--6 Afisati suma preturilor pentru fiecare categorie in parte.
SELECT * FROM Category
SELECT * FROM Product

SELECT c.CategoryId, c.Name,SUM(p.Price)
FROM Category C
LEFT JOIN Product P ON C.CategoryId = P.CategoryId
Group BY c.CategoryId, c.Name
Order By c.CategoryId

--7.Afisati clientii care au mai mult de 10 comenzi.

SELECT * FROM Customer
SELECT * FROM Orders

Select c.CustomerId, c.Name, Count(o.OrderId) as OrderNumbers
From Customer c
Left Join Orders o ON c.CustomerId = o.CustomerId
Group BY c.CustomerId, c.Name
Having Count(o.OrderId)>1
GO;

--8.Creati un view care va afisa toti clientii si produsele comandate de acestia.

CREATE VIEW ProductPerClients2
AS
SELECT c.CustomerId,c.Name as CustomerName ,o.OrderId,o.Date as OrderDate,p.ProductId,p.Name as ProductName,p.Price,ct.CategoryId,ct.Name as CategoryName
FROM Customer c
INNER JOIN Orders o ON c.CustomerId = o.CustomerId
INNER JOIN OrderProduct OP ON o.OrderId = op.OrderId
INNER JOIN Product p ON op.ProductId = p.ProductId
INNER JOIN Category ct ON p.CategoryId = ct.CategoryId
GO;

SELECT * FROM ProductPerClients

--9.Folositi view-ul de la punctul precedent pentru a afisa:
--	Clientii care au comandat produse in primele trei luni ale anului.

SELECT * FROM ProductPerClients1
Where OrderDate <='2019-01-03';
GO;

--	Clientii care au comandat produse dintr-o anumita categorie.

SELECT * FROM ProductPerClients2
Where CategoryName = 'Tablete'
GO;

--10.	Creati o procedura care va modifica statusul unui Order. 
--Aceasta procedura va updata si LastModifiedDate.

ALTER TABLE Orders Add LastModifiedDate Date
GO;

Create Procedure ChangeOrderStatus @Status varchar (50), @OrderId int
AS
UPDATE Orders 
SET Status = @Status,LastModifiedDate = GETDATE()
Where OrderId = @OrderId

EXEC ChangeOrderStatus @Status = 'Complete', @OrderId = 1;

SELECT * FROM Orders

--11.Creati un raport (select cu group by) pentru a afisa vanzarile pentru fiecare produs in parte.
GO;
Create VIEW ORDERID
AS
SELECT OrderId
FROM Orders
GO

CREATE VIEW ProductIDNamePRICE
AS
SELECT ProductId,Name,Price
FROM Product
GO;

select * from ORDERID
select * from OrderProduct
select * from ProductIDNamePRICE


Select p.ProductId,P.Name,op.NumberOfProducts,p.Price,SUM(p.Price*NumberOfProducts) 
FROM ProductIDNamePRICE p 
JOIN OrderProduct op ON p.ProductId = op.ProductId
JOIN ORDERID o ON o.OrderId = op.OrderId
GROUP BY P.ProductId,p.Name, op.NumberOfProducts,p.Price

--12.Creati o functie care va calcula pretul total pentru o anumita comanda.
GO;
CREATE FUNCTION TotalPricePerOrder (@OrderId int)
Returns decimal
AS
BEGIN
declare @Total decimal;
	select @Total = Sum(op.NumberOfProducts * p.Price) 
	  from OrderProduct op
	  LEFT JOIN Orders o on op.OrderId = o.OrderId
	  LEFT JOIN Product p on op.ProductId = p.ProductId
	  where op.OrderId = @OrderId;
	 
	return @Total;
END
GO;

Select dbo.TotalPricePerOrder(1);

--13.Order Audit Table - OrderId, CustomerId, DateTime. - insert trigger

CREATE TABLE OrderAUDIT
(
	OrderId int,
	CustomerId int,
	AddedAt DateTime,
	ApprovedAt DateTime
)
GO

Create trigger OrderInsertAuditTrigger
ON Orders
After Insert
AS
BEGIN
INSERT INTO OrderAUDIT(OrderId,CustomerId,AddedAt)
SELECT i.OrderId,i.CustomerId,GETDATE() from inserted i
END


EXEC InsertOrders @Number = 135,@Date = '2019-01-24', @CustomerId = 4, @Status = 'Processing';

select * from OrderAUDIT

--14.	Order Audit - Cand order-ul are status approved = update pe coloana approvedat in audit table. update trigger
GO;
Create trigger OrderUpdateAuditTrigger1
ON Orders
AFTER UPDATE
AS
BEGIN
UPDATE OrderAUDIT
SET ApprovedAt = GETDATE()
FROM OrderAUDIT
JOIN inserted I ON OrderAUDIT.OrderId = I.OrderId
WHERE Status = 'Aproved'
END

Update Orders SET Status = 'Aproved' where OrderId = 9

select * from OrderAUDIT
