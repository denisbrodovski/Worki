CREATE PROCEDURE [dbo].[uspProductsCategoriesAll]
AS
BEGIN
	SELECT
		ProductName = P.Name,
		CategoryName = C.Name
	FROM Products as P
		LEFT OUTER JOIN ProductsCategories as PC ON PC.ProductId = P.Id
		LEFT OUTER JOIN Categories as C ON C.Id = PC.CategoryId
END
