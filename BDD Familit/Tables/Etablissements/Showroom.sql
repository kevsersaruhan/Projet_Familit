CREATE TABLE [dbo].[Showroom]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nom] NCHAR(60) NOT NULL UNIQUE, 
    [NumBCE] NCHAR(12) NOT NULL, 
    [AdresseId] INT NULL,
    CONSTRAINT FK_Adresse_Showroom FOREIGN KEY ([AdresseId]) REFERENCES [Adresse]([Id])
)
