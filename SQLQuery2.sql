select ContactName Adi,CompanyName ŞirketAdi,City Şehir from customers

select * from customers where city= 'London'

select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice >= 100

select * from Products order by CategoryID,ProductName  asc  -- default asc olarak sırala

select * from Products order by CategoryID,ProductName desc  -- düşen olarak sırala

select * from Products where CategoryID = 3 order by UnitPrice desc 

select COUNT(*) from Products -- tüm kolonları sayar toplamı verir

select COUNT(*) from Products where CategoryID = 5

select categoryId,count(*) from Products group by CategoryID

select categoryId,count(*) from Products where UnitPrice > 20 group by categoryId having count (*) <10

select Products.ProductID , Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where products.UnitPrice >10
-- inner join 2 tablodaki eşleşen verileri getirir

select * from Products p left join[Order Details] od
on p.ProductID = od.ProductID
-- produtsta olup detailste olmayanlarıda getirir left join

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null
-- hiç order ı olmayan müşterileri bulmak








