CREATE TABLE [dbo].[Product_Caracteristique]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductId] INT NOT NULL, 
    [CaracteristiqueId] INT NOT NULL,
    CONSTRAINT FK_Product_Product_Caracteristique FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]) ON DELETE CASCADE,
   CONSTRAINT FK_Caracteristique_Product_Caracteristique FOREIGN KEY (CaracteristiqueId) REFERENCES [Caracteristique]([Id]) ON DELETE CASCADE
)
