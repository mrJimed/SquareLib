SELECT p.ProductName, c.CategoryName
FROM ProductsCategories pc
INNER JOIN Categories c ON pc.Id = c.Id
RIGHT JOIN Products p ON pc.Id = p.Id 