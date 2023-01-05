-- Question 1select Customers.CompanyName from Customers where Customers.CustomerID not in (select distinct Orders.CustomerID from Orders) --Orders.CustomerID = Customers.CustomerID and Orders.CustomerID is null

-- Question 2
select distinct [Order Details].OrderID from [Order Details], Products, Categories where ([Order Details].ProductID = Products.ProductID and Products.CategoryID in (select Categories.CategoryID  where (Categories.CategoryName = 'meat/poultry' or Categories.CategoryName = 'Dairy Products')))

-- Question 3
select distinct [Order Details].OrderID from [Order Details], Products, Categories where ([Order Details].ProductID = Products.ProductID and Products.CategoryID not in (select Categories.CategoryID  from Categories where Categories.CategoryName = 'meat/poultry' or Categories.CategoryName = 'Dairy Products'))

-- Question 4
select  distinct e.FirstName +  ' ' + e.LastName from Employees e where e.EmployeeID in (select top 1 EmployeeID from Orders where datepart(year,Orders.OrderDate)= 1997 order by OrderDate)

-- Question 5
select * from Employees e where e.ReportsTo in (select e.EmployeeID from Employees e where e.ReportsTo is null)

-- Question 6
select * from Employees where Employees.EmployeeID in (select EmployeeTerritories.EmployeeID from EmployeeTerritories where EmployeeTerritories.TerritoryID in (select Territories.TerritoryID from Territories where Territories.RegionID in (select Region.RegionID from Region where Region.RegionDescription = 'Western')))

-- Question 7
select  distinct e.EmployeeID, e.FirstName, e.LastName from employees e, Territories t, EmployeeTerritories et,Region r where e.EmployeeID = et.EmployeeID and  et.TerritoryID = t.TerritoryID and  t.RegionID = r.RegionID and r.RegionID not in (select r.RegionID where r.RegionDescription='Western')

-- Question 8
select distinct o.OrderID from orders o where o.EmployeeID not in (select e.EmployeeID from employees e, Territories t, EmployeeTerritories et,Region r where e.EmployeeID = et.EmployeeID and  et.TerritoryID = t.TerritoryID and  t.RegionID = r.RegionID and r.RegionID in (select r.RegionID where r.RegionDescription='Western'))

-- Question 9
(select c.contactname from Customers c where c.Country ='USA') union (select s.ContactName from suppliers s where s.Country ='USA')

-- Question 10
select p.ProductID, p.ProductName from Products p where p.UnitPrice in (select min(p.UnitPrice) from Products p)

-- Question 11
select distinct s.SupplierID, s.CompanyName from Suppliers s where s.SupplierID in (select s.SupplierID from Suppliers s, Products p, Categories c where s.SupplierID = p.SupplierID and p.CategoryID = c.CategoryID and c.CategoryName = 'Beverages')

-- Question 13
select e.EmployeeID, e.FirstName, e.LastName, CASE when (DATEDIFF(year, e.hiredate, getdate())) > 5 then '3' when (DATEDIFF(year, e.hiredate, getdate())) >= 3 and (DATEDIFF(year, e.hiredate, getdate())) <= 5 then '2' else '1' end as SeniorityLevel from Employees e

-- Question 14
select p.ProductName, CASE when p.unitprice > 80 then 'Costly' when p.unitprice >= 30 and p.unitprice <= 80 then 'Economical' else 'Cheap' end as ProductType from products p