GO
USE master

GO
CREATE DATABASE GeekJobDb

GO
USE GeekJobDb

GO
CREATE TABLE Categories 
(
[Id] INT PRIMARY KEY Identity,
[Name] NVARCHAR (225) UNIQUE NOT NULL 
)

GO
CREATE TABLE Products 
(
[Id] INT PRIMARY KEY Identity,
[Name] NVARCHAR (225) UNIQUE NOT NULL 
)

GO
CREATE TABLE ProductsCategories
(
[Id] INT PRIMARY KEY Identity,
[ProductId] INT FOREIGN KEY REFERENCES Products(Id),
[CategoryId] INT FOREIGN KEY REFERENCES Categories(Id),
)


-----------------------------------------Bulk Insertion of some Entities


GO
 INSERT INTO Categories VALUES (N'Electronics')
 INSERT INTO Categories VALUES (N'Action Cameras')
 INSERT INTO Categories VALUES (N'Footwear')
 INSERT INTO Categories VALUES (N'Books and Literature')
 INSERT INTO Categories VALUES (N'Clothing')
 INSERT INTO Categories VALUES (N'Baby and Kids')
 INSERT INTO Categories VALUES (N'Outdoor and Garden')
 INSERT INTO Categories VALUES (N'Home Decor')
 INSERT INTO Categories VALUES (N'Consumable')
 INSERT INTO Categories VALUES (N'Sports and Fitness')

 

 GO
 INSERT INTO Products VALUES(N'Adidas Ultraboost')
 INSERT INTO Products VALUES(N'GoPro Hero 9')
 INSERT INTO Products VALUES(N'Apple Watch Series 6')
 INSERT INTO Products VALUES(N'Harry Potter and the Chamber of Secrets')
 INSERT INTO Products VALUES(N'Nike Air Jordan 1')
 INSERT INTO Products VALUES(N'LEGO Creator Expert Taj Mahal')
 INSERT INTO Products VALUES(N'Apple iPad Pro')
 INSERT INTO Products VALUES(N'Dell G3')
 INSERT INTO Products VALUES(N'AA Batteries')
 INSERT INTO Products VALUES(N'Pull&Bear Puff Jacket')
 INSERT INTO Products VALUES(N'Doritos Spicy')
 INSERT INTO Products VALUES(N'Sticky Notes')


 GO
 INSERT INTO ProductsCategories VALUES (1,3)
 INSERT INTO ProductsCategories VALUES (1,5)
 INSERT INTO ProductsCategories VALUES (1,10)
 INSERT INTO ProductsCategories VALUES (2,1)
 INSERT INTO ProductsCategories VALUES (2,2)
 INSERT INTO ProductsCategories VALUES (3,1)
 INSERT INTO ProductsCategories VALUES (4,4)
 INSERT INTO ProductsCategories VALUES (5,3)
 INSERT INTO ProductsCategories VALUES (5,10)
 INSERT INTO ProductsCategories VALUES (6,6)
 INSERT INTO ProductsCategories VALUES (7,1)
 INSERT INTO ProductsCategories VALUES (8,1)
 INSERT INTO ProductsCategories VALUES (10,5)
 INSERT INTO ProductsCategories VALUES (10,6)
 INSERT INTO ProductsCategories VALUES (11,9)



 --Запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

 SELECT Products.Name AS [Имя Продукта], Categories.Name AS [Имя категории]  FROM Products 
 LEFT JOIN ProductsCategories ON Products.Id = ProductsCategories.ProductId
 LEFT JOIN Categories ON Categories.Id = ProductsCategories.CategoryId
 ORDER BY Products.Id