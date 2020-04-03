CREATE TABLE [dbo].[Personnel]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nom] NVARCHAR(60) NOT NULL, 
    [Prenom] NVARCHAR(60) NOT NULL, 
    [DateDeNaissance] DATE NOT NULL, 
    [Login] NVARCHAR(60) NOT NULL UNIQUE, 
    [Password] NVARCHAR(60) NOT NULL, 
    [Fonction] NVARCHAR(60) NOT NULL, 
    [IsAdmin] NVARCHAR(10) NOT NULL DEFAULT 0, 
    [DateDEngagement] DATE NOT NULL, 
    [NbJourAbsence] INT NULL, 
    [NbJourVacances] INT NULL, 
    [Salaire] FLOAT NOT NULL, 
    [AdresseId] INT NULL,
    [ShowroomId] INT NOT NULL, 
    [IsActif] BIT NOT NULL, 
    CONSTRAINT FK_Adresse_Personnel FOREIGN KEY ([AdresseId]) REFERENCES [Adresse]([Id]),
    CONSTRAINT FK_Showroom_Personnel FOREIGN KEY ([ShowroomId]) REFERENCES [Showroom]([Id]),
    CONSTRAINT CK_Personnel_Fonction CHECK ([Fonction] = 'Livreur' OR [Fonction] = 'Vendeur' OR [Fonction] ='Gerant')

)
