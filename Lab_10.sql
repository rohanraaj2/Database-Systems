-- Question 1
Create view [Products Summary] as
select Products.ProductName, min(Suppliers.ContactName) as Supplier, min(Categories.CategoryName) as Category, min(Products.UnitPrice) as Price, 
count(Orders.OrderID) as 'Number of Orders', sum([Order Details].Quantity) as Quantity from products, Suppliers, Categories, Orders,[Order Details] where 
Suppliers.SupplierID = Products.SupplierID and Categories.CategoryID = Products.CategoryID and products.productID = [Order Details].productID 
group by Products.ProductName;

select * from [Products Summary]

-- Question 2
/* alter PROCEDURE EmployeeName 


@firstname varchar(20),
@lastname varchar(20)
AS
select Employees.FirstName + Employees.LastName as 'Full Name' from Employees where @firstname = Employees.FirstName and 
@lastname = Employees.LastName
exec EmployeeName 'Nancy','Davolio'

select * from Employees */

Create view [Customers Summary] as
select Employees.FirstName + ' ' + Employees.LastName as 'Full Name', Employees.FirstName + ' ' + Employees.LastName as 'Manager Name',  
DATEDIFF(year, Employees.BirthDate, GETDATE()) as Age, DATEDIFF(year, Employees.HireDate, GETDATE()) as 'No. of years
with the company', count([Order Details].select Customers.CustomerID from Customers) from Employees, [Order Details]


-- Question 3
Create Procedure Discount (@ProductID int, @Discount float)
As
Begin
Update Products
set UnitPrice = UnitPrice * (1 - @Discount)
where ProductID = @ProductID

update [Order Details]
set Discount = Discount + @Discount


-- Question 4
create proc DeleteEmployee @e1 int
as 
begin
	if((select ReportsTo 
	from Employees 
	where EmployeeID = @e1) is not null ) and (@e1 not in (select EmployeeID from Orders))
	begin
		delete EmployeeTerritories 
		where EmployeeID = @e1;

		update Employees
			set ReportsTo = (select ReportsTo 
			from Employees 
			where EmployeeID = @e1)
			where ReportsTo = @e1

		delete Employees
		where EmployeeID = @e1
	end
end
go

-- Question 5
create proc Copyorders @oID int, @cID varchar
as
begin 
	insert into Orders
	select CustomerID, EmployeeID, GETDATE(), null, null, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry
	from Orders 
	where OrderID = @oID and CustomerID = @cID
end
go
