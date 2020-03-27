CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nom] NCHAR(60) NOT NULL, 
    [Prenom] NCHAR(60) NOT NULL, 
    [Login] NCHAR(60) NULL, 
    [Password] NCHAR(10) NULL,
    [AdresseId] INT NULL, 
    [NumBCE] NCHAR(12) NULL, 
    [EstFournisseur] BIT NOT NULL, 
    CONSTRAINT FK_Adresse_Client FOREIGN KEY ([AdresseId]) REFERENCES [Adresse]([Id])
    
)
