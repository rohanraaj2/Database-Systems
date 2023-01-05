-- Question 1
select Orders.OrderID, Orders.OrderDate, Products.ProductName from Orders, Products, [Order Details] where [Order Details].OrderID = Orders.OrderID and [Order Details].ProductID = Products.ProductID;

-- Question 2
select Orders.OrderID, Orders.OrderDate, Products.ProductName, Customers.ContactName from Orders, Products, Customers, [Order Details] where [Order Details].OrderID = Orders.OrderID and [Order Details].ProductID = Products.ProductID;

-- Question 3
select Orders.OrderID, Orders.OrderDate, Products.ProductName, Categories.CategoryName,Customers.ContactName from Orders, Products, Categories, Customers, [Order Details] where [Order Details].OrderID = Orders.OrderID and [Order Details].ProductID = Products.ProductID and Products.CategoryID = Categories.CategoryID;

-- Question 4
select Orders.OrderID, Orders.OrderDate, Products.ProductName from Orders, Products, [Order Details], Categories where ([Order Details].OrderID = Orders.OrderID and [Order Details].ProductID = Products.ProductID and Products.CategoryID = Categories.CategoryID and Categories.CategoryName = 'Seafood');

-- Question 5
select count(*) from Products, Orders, [Order Details] where Orders.OrderID = 11070 and [Order Details].OrderID = Orders.OrderID and [Order Details].ProductID = Products.ProductID;

-- Question 6
select Suppliers.CompanyName, count(*) as No_of_Products from Suppliers, Products where Suppliers.SupplierID = Products.SupplierID group by Suppliers.CompanyName order by No_of_Products;

-- Question 7
select Suppliers.CompanyName, Categories.CategoryName, count(*) as No_of_Products, avg(Products.UnitPrice) as Average_Unit_Products, sum(Products.UnitsInStock) as Units_in_Stock from Suppliers, Categories, Products where Products.CategoryID = Categories.CategoryID and Products.SupplierID = Suppliers.SupplierID group by Suppliers.CompanyName, Categories.CategoryName order by CompanyName;

-- Question 8


-- Question 9


-- Question 10


-- Question 11


-- Question 12


-- Question 13


-- Question 14


-- Question 15


-- Question 16


-- Question 17


-- Question 18


-- Question 19


-- Question 20

