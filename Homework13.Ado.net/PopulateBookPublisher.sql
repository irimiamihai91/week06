Select * from Book
Select * from Publisher


INSERT INTO Publisher (PublisherId,Name) VALUES (1,'Polirom');
INSERT INTO Publisher (PublisherId,Name) VALUES (2,'For you');
INSERT INTO Publisher (PublisherId,Name) VALUES (3,'Litera');
INSERT INTO Publisher (PublisherId,Name) VALUES (4,'Nemira');
INSERT INTO Publisher (PublisherId,Name) VALUES (5,'Rao');
INSERT INTO Publisher (PublisherId,Name) VALUES (6,'Litera');
INSERT INTO Publisher (PublisherId,Name) VALUES (7,'Trei');
INSERT INTO Publisher (PublisherId,Name) VALUES (8,'Asa');
INSERT INTO Publisher (PublisherId,Name) VALUES (9,'Art');

INSERT INTO Book(Title, PublisherId, Year, Price ) 
	VALUES ('De veghe in lanul de secara’',1,2016,17);
INSERT INTO Book(Title, PublisherId, Year, Price) 
	VALUES ('Fluturi',2,2016,13);
INSERT INTO Book(Title, PublisherId, Year, Price) 
	VALUES ('Proza',3,2011,8);
INSERT INTO Book(Title, PublisherId, Year, Price) 
	VALUES ('Portretul lui Dorian Grey',1,2013,18);
INSERT INTO Book(Title, PublisherId, Year, Price) 
	VALUES ('Urzeala tronurilor',4,2017,30);
INSERT INTO Book(Title, PublisherId, Year, Price) 
	VALUES ('Numele vantului',5,2017,35);
INSERT INTO Book(Title, PublisherId, Year, Price) 
	VALUES ('Cartea vietii',6,2017,24);
INSERT INTO Book(Title, PublisherId, Year, Price) 
	VALUES ('Chimista’',7,2016,33);
INSERT INTO Book(Title, PublisherId, Year, Price) 
	VALUES ('Baltagul',8,2014,22);
INSERT INTO Book(Title, PublisherId, Year, Price) 
	VALUES ('Harry Potter vol. 5',9,2017,64);
INSERT INTO Book(Title, PublisherId, Year, Price) 
	VALUES ('Puterea armelor',4,2017,35);