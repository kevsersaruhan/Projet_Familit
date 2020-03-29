CREATE TABLE [dbo].[LignesDeCommandes]
(
	[Id] INT NOT NULL PRIMARY KEY,
  [ProductName] NCHAR(100),
    [Total] FLOAT NOT NULL, 
    [Quantite] INT NOT NULL, 
    [HTVA] FLOAT NOT NULL, 
    [TVAC] FLOAT NOT NULL, 
    [ProductId] INT NOT NULL,
    [CommandeId] INT NOT NULL, 
    CONSTRAINT FK_Product_LigneDeCommandes FOREIGN KEY ([ProductId]) REFERENCES [Product]([Id]) ON DELETE CASCADE,
    CONSTRAINT FK_Commande_LigneDeCommandes FOREIGN KEY ([CommandeId]) REFERENCES [Commande]([Id]) ON DELETE CASCADE
)
