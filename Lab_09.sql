-- Question 1
set identity_insert products on;
Insert into Products (ProductID, ProductName, CategoryID, UnitPrice) values (2050, 'Mountain Dew', 1, 10);

-- Question 2
set identity_insert Categories on;
Insert into Products (ProductID, ProductName, CategoryID, UnitPrice) values (2051, 'Tea', (select Categories.CategoryID from Categories where Categories.CategoryName = 'Beverages'), 10);

-- Question 3
update Products
set products.UnitPrice = 1.25 * (products.UnitPrice) where Products.CategoryID in (select Categories.CategoryID from Categories where Categories.CategoryName = 'Beverages')

-- Question 4
update [Order Details]
Set UnitPrice = (0.8 * UnitPrice) where OrderID in (select OrderID from Orders where ShippedDate is NULL)

-- Question 5
set identity_insert Categories on;
Insert into Categories (CategoryName) values ('Drinks')

-- Question 6
set identity_insert products on;
Insert into products (ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) 
(select ProductID, ProductName, SupplierID, (select Categories.CategoryID from Categories where Categories.CategoryName = 'Drinks'), QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued from Products, Categories where Products.CategoryID = Categories.CategoryID and Categories.CategoryName = 'Beverages')

-- Question 7
update Products
set CategoryID = (select Categories.CategoryID from Categories where Categories.CategoryName = 'Drinks') where CategoryID = (select Categories.CategoryID from Categories where Categories.CategoryName = 'Beverages')

-- Question 8
Delete EmployeeTerritories where EmployeeTerritories.EmployeeID = (Select Employees.EmployeeID from Employees where Employees.FirstName = 'Nancy' and Employees.LastName = 'Davolio')

insert into EmployeeTerritories(EmployeeID, TerritoryID) select (Select Employees.EmployeeID from Employees where Employees.FirstName = 'Nancy' and Employees.LastName = 'Davolio'), EmployeeTerritories.TerritoryID from EmployeeTerritories, Employees where EmployeeTerritories.EmployeeID = Employees.EmployeeID and Employees.FirstName = 'Robert' and Employees.LastName = 'King'


-- Question 9
--a:
update Employees
set ReportsTo = (select Employees.EmployeeID from Employees where Employees.FirstName = 'Robert' and Employees.LastName = 'King') where Employees.ReportsTo = (select EmployeeID from Employees where Employees.FirstName = 'Steven' and Employees.LastName = 'Buchanan')

--b:
update Orders
set EmployeeID = (select Employees.ReportsTo from Employees where Employees.EmployeeID = (select EmployeeID from Employees where Employees.FirstName = 'Steven' and Employees.LastName = 'Buchanan')) where EmployeeID = (select EmployeeID from Employees where Employees.FirstName = 'Steven' and Employees.LastName = 'Buchanan');

--c:
delete EmployeeTerritories where EmployeeTerritories.EmployeeID = (select EmployeeID from Employees where Employees.FirstName = 'Steven' and Employees.LastName = 'Buchanan');

--d:
delete Employees where EmployeeID = (select EmployeeID from Employees where Employees.FirstName = 'Steven' and Employees.LastName = 'Buchanan');

-- Question 10
Delete Products where Products.UnitPrice > 1000;


-- Question 11
Delete Products where ((Products.CategoryID = (Select Categories.CategoryID from Categories where Categories.CategoryName = 'Seafood')) and UnitsInStock < 5)

-- Question 12
Delete Categories where Categories.CategoryID = (select Categories.CategoryID from Categories where Categories.CategoryID not in (select distinct Products.CategoryID from Products));

-- Question 13
Delete [Order Details] where [Order Details].OrderID in (select Orders.OrderID from Orders where CustomerID =  'ALFKI')
Delete Orders where Orders.CustomerID =  'ALFKI';


-- Question 14
Delete [Order Details] where [Order Details].OrderID in (select Orders.OrderID from Orders where ((datepart(year, Orders.ShippedDate)) = 1996) and ((datepart(MONTH, Orders.ShippedDate)) = 8));
Delete Orders where ((datepart(year, Orders.ShippedDate)) = 1996) and ((datepart(MONTH, Orders.ShippedDate)) = 8)
