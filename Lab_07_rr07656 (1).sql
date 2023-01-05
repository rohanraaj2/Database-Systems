-- Question 1
select Orders.OrderID, Orders.OrderDate, Products.ProductName from Orders, Products, [Order Details] where [Order Details].OrderID = Orders.OrderID and [Order Details].ProductID = Products.ProductID;

-- Question 2
select Orders.OrderID, Orders.OrderDate, Products.ProductName, Customers.ContactName from Orders, Products, Customers, [Order Details] where [Order Details].OrderID = Orders.OrderID and [Order Details].ProductID = Products.ProductID and Customers.CustomerID = Orders.CustomerID;

-- Question 3
select Orders.OrderID, Orders.OrderDate, Products.ProductName, Categories.CategoryName,Customers.ContactName from Orders, Products, Categories, Customers, [Order Details] where [Order Details].OrderID = Orders.OrderID and [Order Details].ProductID = Products.ProductID and Products.CategoryID = Categories.CategoryID and Customers.CustomerID = Orders.CustomerID;

-- Question 4
select Orders.OrderID, Orders.OrderDate, Products.ProductName from Orders, Products, [Order Details], Categories where ([Order Details].OrderID = Orders.OrderID and [Order Details].ProductID = Products.ProductID and Products.CategoryID = Categories.CategoryID and Categories.CategoryName = 'Seafood');

-- Question 5
select count(*) from Products, Orders, [Order Details] where Orders.OrderID = 11070 and [Order Details].OrderID = Orders.OrderID and [Order Details].ProductID = Products.ProductID;

-- Question 6
select Suppliers.CompanyName, count(*) as No_of_Products from Suppliers, Products where Suppliers.SupplierID = Products.SupplierID group by Suppliers.CompanyName order by No_of_Products;

-- Question 7
select Suppliers.CompanyName, Categories.CategoryName, count(*) as No_of_Products, avg(Products.UnitPrice) as Average_Unit_Products, sum(Products.UnitsInStock) as Units_in_Stock from Suppliers, Categories, Products where Products.CategoryID = Categories.CategoryID and Products.SupplierID = Suppliers.SupplierID group by Suppliers.CompanyName, Categories.CategoryName order by CompanyName;

-- Question 8
select Suppliers.CompanyName from Suppliers, Products where Suppliers.SupplierID = Products.SupplierID group by Suppliers.CompanyName having (count(*) > 4)

-- Question 9
select Region.RegionDescription, count(*) as 'Number of Employees' from Employees, EmployeeTerritories, Territories, Region where Employees.EmployeeID = EmployeeTerritories.EmployeeID and EmployeeTerritories.TerritoryID = Territories.TerritoryID and Territories.RegionID = Region.RegionID group by Region.RegionDescription

-- Question 10
select sum (([Order Details].Quantity * [Order Details].UnitPrice) - [Order Details].Discount) as 'Total Amount' from [Order Details] where [Order Details].OrderID = 11070

-- Question 11
select [Order Details].OrderID, sum (([Order Details].Quantity * [Order Details].UnitPrice) - [Order Details].Discount) as 'Total Amount' from [Order Details] group by [Order Details].OrderID

-- Question 12
select Categories.CategoryName, count(*) as 'Number of Products' from Products, Categories where Products.CategoryID = Categories.CategoryID group by Categories.CategoryName

-- Question 13
select Customers.ContactName, Suppliers.ContactName, count(*) as 'Number of orders' from Customers, Suppliers, Orders, [Order Details], Products where Customers.CustomerID = Orders.CustomerID and Orders.OrderID = [Order Details].OrderID and [Order Details].ProductID = Products.ProductID and Products.SupplierID = Suppliers.SupplierID group by Customers.ContactName, Suppliers.ContactName

-- Question 14
select Employees.FirstName + ' ' + Employees.LastName as 'Employee Name', datepart(year, Orders.OrderDate), count(*) as 'Number of orders' from Employees, Orders where Employees.EmployeeID = Orders.EmployeeID group by Employees.FirstName + ' ' + Employees.LastName,datepart(year, Orders.OrderDate)

-- Question 15
select M.FirstName + ' ' + M.LastName as 'Manager Name', E.FirstName + ' ' + E.LastName as 'Employee Name', count(*) as 'Number of Orders' from Employees E inner join Employees M on E.ReportsTo = M.EmployeeID inner join Orders O on O.EmployeeID = E.EmployeeID group by M.FirstName + ' ' + M.LastName, E.FirstName + ' ' + E.LastName


-- Question 16
select ContactName from Customers C left outer join Orders O on C.CustomerID = O.CustomerID where OrderID is null

-- Question 17
select O.OrderID from Orders O inner join [Order Details] OD on O.OrderID = OD.OrderID inner join Products P on OD.ProductID = P.ProductID inner join Categories C on P.CategoryID = C.CategoryID where CategoryName = 'Meat/Poultry' or CategoryName = 'Dairy Products'

-- Question 18
select Region.RegionDescription, count(*) as 'Number of Employees' from Region, Employees, EmployeeTerritories, Territories where Employees.EmployeeID = EmployeeTerritories.EmployeeID and EmployeeTerritories.TerritoryID = Territories.TerritoryID and Territories.RegionID = Region.RegionID group by Region.RegionDescription

-- Question 19
select Employees.FirstName + ' ' + Employees.LastName as 'Employee Name', Customers.ContactName from Employees, Customers

-- Question 20
select CompanyName, count(*) as 'Orders Fulfilled' from Orders O inner join Shippers S on O.ShipVia = s.ShipperID where O.ShippedDate is not NULL group by CompanyName
