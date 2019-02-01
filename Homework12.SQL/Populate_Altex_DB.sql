EXEC InsertCustomer @name = 'Daniel Ionescu', @Email = 'ionescu@gmail.com';
EXEC InsertCustomer @name = 'Mihai Popescu', @Email = 'popescu@wantsome.com';
EXEC InsertCustomer @name = 'Bogdan Popoi', @Email = 'popoi@gmail.com';
EXEC InsertCustomer @name = 'Alexandru Bucatar', @Email = 'bucatar@gmail.com';
EXEC InsertCustomer @name = 'Ionel Roman', @Email = 'roman@gmail.com';
EXEC InsertCustomer @name = 'Mihai Eminescu', @Email = 'eminescu@gmail.com';
EXEC InsertCustomer @name = 'George Popescu', @Email = 'popescu@gmail.com';
GO;

EXEC InsertEmployee @Name = 'George Gonescu', @Email = 'gonescu@altex.com';
EXEC InsertEmployee @Name = 'Mihai Dumiotrescu', @Email = 'Dumiotrescu@altex.com';
EXEC InsertEmployee @Name = 'Ion Dalescu', @Email = 'Dalescu@altex.com';
EXEC InsertEmployee @Name = 'Vasile Danilescu', @Email = 'Danilescu@altex.com';
EXEC InsertEmployee @Name = 'Ionel Basescu', @Email = 'Basescu@tex.com';
GO;

EXEC InsertCategory @EmployeeId = 1, @Name = 'Telefoane';
EXEC InsertCategory @EmployeeId = 2, @Name = 'Desktop';
EXEC InsertCategory @EmployeeId = 3, @Name = 'Audio';
EXEC InsertCategory @EmployeeId = 3, @Name = 'Video';
EXEC InsertCategory @EmployeeId = 1, @Name = 'Tablete';
EXEC InsertCategory @EmployeeId = 2, @Name = 'Laptop';
EXEC InsertCategory @EmployeeId = 4, @Name = 'TV';
EXEC InsertCategory @EmployeeId = 5, @Name = 'Electrocasnice';
EXEC InsertCategory @EmployeeId = 6, @Name = 'Cosmetice';
EXEC InsertCategory @EmployeeId = 6, @Name = 'Copii';
EXEC InsertCategory @EmployeeId = 2, @Name = 'Auto-Moto';
GO;

EXEC InsertProduct @CategoryId = 1,@Name = 'Samsung S9',@Price = 2600;
EXEC InsertProduct @CategoryId = 1,@Name = 'Telefon HUAWEI P20 Pro',@Price = 2799;
EXEC InsertProduct @CategoryId = 1,@Name = 'Telefon SAMSUNG Galaxy A8',@Price = 1299;
EXEC InsertProduct @CategoryId = 1,@Name = 'Telefon HUAWEI P20 Lite',@Price = 2799;
EXEC InsertProduct @CategoryId = 1,@Name = 'Telefon HUAWEI P20 Pro',@Price = 2799;
EXEC InsertProduct @CategoryId = 2,@Name = 'Sistem PC Gaming MYRIA Style ',@Price = 2999;
EXEC InsertProduct @CategoryId = 2,@Name = 'Sistem PC All in One LENOVO ',@Price = 2499;
EXEC InsertProduct @CategoryId = 2,@Name = 'Sistem PC HP Pavilion 590',@Price = 1999;
EXEC InsertProduct @CategoryId = 2,@Name = 'Sistem PC All in One HP',@Price = 2799;
EXEC InsertProduct @CategoryId = 3,@Name = 'Boxa portabila activa SAL PAB ',@Price = 399;
EXEC InsertProduct @CategoryId = 3,@Name = 'Sistem audio PANASONIC',@Price = 2899;
EXEC InsertProduct @CategoryId = 3,@Name = 'Sistem audio High Power SONY ',@Price = 799;
EXEC InsertProduct @CategoryId = 4,@Name = 'Blu-ray player curbat Smart  ',@Price = 299;
EXEC InsertProduct @CategoryId = 4,@Name = 'Blu-ray player Smart 3D 4K  ',@Price = 209;
EXEC InsertProduct @CategoryId = 4,@Name = 'DVD player SONY DVP-SR760H ',@Price = 149;
EXEC InsertProduct @CategoryId = 5,@Name = 'Tableta ALLVIEW AX502 8GB ',@Price = 259;
EXEC InsertProduct @CategoryId = 5,@Name = 'Tableta HUAWEI Mediapad M5  ',@Price = 1549;
EXEC InsertProduct @CategoryId = 5,@Name = 'Tableta SAMSUNG Tab A T585  ',@Price = 1099;
EXEC InsertProduct @CategoryId = 6,@Name = 'Laptop Gaming ASUS  ',@Price = 2799;
EXEC InsertProduct @CategoryId = 6,@Name = 'Laptop ASUS X542UA-DM521,   ',@Price = 1899;
EXEC InsertProduct @CategoryId = 7,@Name = 'Televizor LED Smart Full HD ',@Price = 1249;
EXEC InsertProduct @CategoryId = 7,@Name = 'Televizor LED High Definition ',@Price = 549;
EXEC InsertProduct @CategoryId = 8,@Name = 'Masina de spalat frontala  ',@Price = 999;
EXEC InsertProduct @CategoryId = 8,@Name = 'Masina de spalat frontala  ',@Price = 1999;
EXEC InsertProduct @CategoryId = 11,@Name = 'Player auto JVC KD-X352BT  ',@Price = 399;
EXEC InsertProduct @CategoryId = 11,@Name = 'MP5 player auto PNI MP5 ',@Price = 249;
GO;


EXEC InsertOrders @Number = 124,@Date = '2019-01-01', @CustomerId = 1, @Status = 'Processing';
EXEC InsertOrders @Number = 125,@Date = '2019-01-02', @CustomerId = 2, @Status = 'Aproved';
EXEC InsertOrders @Number = 126,@Date = '2019-01-03', @CustomerId = 3, @Status = 'Complete';
EXEC InsertOrders @Number = 127,@Date = '2019-01-04', @CustomerId = 4, @Status = 'Cancel';
EXEC InsertOrders @Number = 128,@Date = '2019-01-05', @CustomerId = 5, @Status = 'Complete';
EXEC InsertOrders @Number = 129,@Date = '2019-01-06', @CustomerId = 6, @Status = 'Aproved';
EXEC InsertOrders @Number = 130,@Date = '2019-01-07', @CustomerId = 7, @Status = 'Processing';
GO;

EXEC InsertOrderProduct @OrderId =1,@ProductId = 10,@NumberOfProducts = 1;
EXEC InsertOrderProduct @OrderId =2,@ProductId = 11,@NumberOfProducts = 2;
EXEC InsertOrderProduct @OrderId =3,@ProductId = 12,@NumberOfProducts = 1;
EXEC InsertOrderProduct @OrderId =4,@ProductId = 13,@NumberOfProducts = 2;
EXEC InsertOrderProduct @OrderId =5,@ProductId = 14,@NumberOfProducts = 1;
EXEC InsertOrderProduct @OrderId =6,@ProductId = 15,@NumberOfProducts = 2;
EXEC InsertOrderProduct @OrderId =7,@ProductId = 16,@NumberOfProducts = 1;
EXEC InsertOrderProduct @OrderId =1,@ProductId = 17,@NumberOfProducts = 2;
EXEC InsertOrderProduct @OrderId =2,@ProductId = 18,@NumberOfProducts = 1;
EXEC InsertOrderProduct @OrderId =3,@ProductId = 19,@NumberOfProducts = 2;
EXEC InsertOrderProduct @OrderId =4,@ProductId = 20,@NumberOfProducts = 2;
EXEC InsertOrderProduct @OrderId =5,@ProductId = 21,@NumberOfProducts = 1;
EXEC InsertOrderProduct @OrderId =6,@ProductId = 22,@NumberOfProducts = 2;
EXEC InsertOrderProduct @OrderId =7,@ProductId = 23,@NumberOfProducts = 1;
EXEC InsertOrderProduct @OrderId =1,@ProductId = 24,@NumberOfProducts = 2;
EXEC InsertOrderProduct @OrderId =6,@ProductId = 25,@NumberOfProducts = 1;
EXEC InsertOrderProduct @OrderId =7,@ProductId = 26,@NumberOfProducts = 2;
EXEC InsertOrderProduct @OrderId =8,@ProductId = 27,@NumberOfProducts = 1;

GO


