CREATE TABLE [dbo].[Showroom]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nom] NVARCHAR(60) NOT NULL UNIQUE, 
    [NumBCE] NVARCHAR(12) NOT NULL, 
    [AdresseId] INT NULL,
    [IsActif] BIT NOT NULL, 
    CONSTRAINT FK_Adresse_Showroom FOREIGN KEY ([AdresseId]) REFERENCES [Adresse]([Id])
)
