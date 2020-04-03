CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Prix] FLOAT NOT NULL, 
    [PrixDAchatHTVA] FLOAT NOT NULL, 
    [TVA] FLOAT NOT NULL, 
    [NbPiece] INT NOT NULL, 
    [Details] NVARCHAR(MAX) NOT NULL, 
    [CategorieId] INT NOT NULL,
    [ClientId] INT NOT NULL,
    [Nom] NCHAR(30) NOT NULL, 
    [IsActif] BIT NOT NULL, 
    CONSTRAINT FK_Categorie_Product  FOREIGN KEY ([CategorieId]) REFERENCES [Categories]([Id]) ON DELETE CASCADE,
    CONSTRAINT FK_Client_Product FOREIGN KEY ([ClientId]) REFERENCES [Client]([Id])
)
