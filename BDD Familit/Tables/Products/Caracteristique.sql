CREATE TABLE [dbo].[Caracteristique]
(
	 [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
   [Nom] NCHAR(60) NOT NULL, 
   [Details] NTEXT NULL,
   [CategorieId] int NULL,
   CONSTRAINT FK_Categorie_Caracteristique FOREIGN KEY ([CategorieId]) REFERENCES [Categories]([Id]) ON DELETE CASCADE
)
