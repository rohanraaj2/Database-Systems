-- Question 1
select * from Customers;

-- Question 2
select OrderID, OrderDate, ShipCity, ShipCountry from Orders;

-- Question 3
select OrderID, OrderDate, CustomerID from Orders where ShipCountry = 'France';

-- Question 4
select OrderID, OrderDate, CustomerID from Orders where ShipCountry = 'France' or ShipCountry = 'Germany';

-- Question 5
select OrderID, OrderDate, CustomerID from Orders where (ShipCountry = 'France' or ShipCountry = 'Germany') and Freight > 40;

-- Question 6
select OrderID, OrderDate, CustomerID from Orders where ShipName = 'Quick-Stop';

-- Question 7
select TitleOfCourtesy  + ' ' + FirstName + ' ' + LastName from Employees;

-- Question 8
select OrderID, OrderDate, ShipName, ShipAddress, ShipCity, ShipCountry from Orders where ShipAddress like '%box%';

-- Question 9
select OrderId, CustomerID from Orders where CustomerID like 'A%I';

-- Question 10
select FirstName from Employees where datepart(year,getdate()) - datepart(year,hiredate) > 10;

-- Question 11
select datediff(day,OrderDate,ShippedDate),* from Orders

-- Question 12
select * from Orders where datepart(MONTH,OrderDate) = 6;

-- Question 13
select * from Customers where Fax IS NULL;

-- Question 14
select * from Products where QuantityPerUnit like '%boxes%';

-- Question 15
select * from Suppliers where Fax is not null;

-- Question 16
select count(*) from Customers where Fax IS NULL;

-- Question 17
select count(*) from Suppliers;

-- Question 18
select count(*) from Orders where datepart(year, OrderDate) = 1997;

-- Question 19
select count(*) from Customers where Country = 'UK';

-- Question 20
select sum(unitsinstock) from products

-- Question 21
select sum(unitsinstock*UnitPrice) from products