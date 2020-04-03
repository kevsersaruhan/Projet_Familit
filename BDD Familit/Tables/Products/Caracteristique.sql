CREATE TABLE [dbo].[Caracteristique]
(
	 [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
   [Nom] NVARCHAR(60) NOT NULL, 
   [Details] NVARCHAR(MAX) NULL,
   [CategorieId] int NULL,
   CONSTRAINT FK_Categorie_Caracteristique FOREIGN KEY ([CategorieId]) REFERENCES [Categories]([Id])
)
