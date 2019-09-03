CREATE TABLE [dbo].[ProductsCategories]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProductId] INT NOT NULL, 
    [CategoryId] INT NOT NULL, 
    CONSTRAINT [fkProductsCategories_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products]([Id]), 
    CONSTRAINT [fkProductsCategories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id])
)
