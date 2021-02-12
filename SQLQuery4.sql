Select ProductName ÜrünAdı, 
Sum([Order Details].Quantity * [Order Details].UnitPrice) AS KazanılanToplamMiktar 
from [Order Details]
Right join Products on [Order Details].ProductID = Products.ProductID
group by ProductName