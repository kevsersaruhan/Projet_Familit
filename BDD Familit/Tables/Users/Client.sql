CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nom] NVARCHAR(60) NOT NULL, 
    [Prenom] NVARCHAR(60) NOT NULL, 
    [Login] NVARCHAR(60) NULL, 
    [Password] NVARCHAR(10) NULL,
    [AdresseId] INT NOT NULL, 
    [NumBCE] NVARCHAR(12) NULL, 
    [EstFournisseur] BIT NOT NULL, 
    [IsActif] BIT NOT NULL, 
    CONSTRAINT FK_Adresse_Client FOREIGN KEY ([AdresseId]) REFERENCES [Adresse]([Id])
    
)
