CREATE TABLE [dbo].[Commande]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DateCommande] DATE NOT NULL, 
    [Total] DECIMAL NOT NULL, 
    [Acompte] DECIMAL NOT NULL, 
    [Solde] DECIMAL NOT NULL, 
    [MoyenDePaiement] NCHAR(10) NULL, 
    [Statut] NCHAR(10) NULL, 
    [Livraison] BIT NULL, 
    [DateDeLivraison] DATE NULL, 
    [TypeDeCommande] NCHAR(30) NOT NULL, 
    [ClientId] INT NOT NULL, 
    [PersonnelId] INT NULL, 
    [ShowroomID] INT NULL,
    CONSTRAINT FK_Personnel_Commande  FOREIGN KEY ([PersonnelId]) REFERENCES [Personnel]([Id]) ON DELETE CASCADE,
    CONSTRAINT FK_Showroom_Commande FOREIGN KEY  ([ShowroomId]) REFERENCES [Showroom]([Id]) ON DELETE CASCADE,
    CONSTRAINT FK_Client_Commande FOREIGN KEY ([ClientId]) REFERENCES [Client]([Id]) ON DELETE CASCADE,
    CONSTRAINT XORIT CHECK  (([PersonnelId] IS NOT NULL AND [ShowroomId] IS NULL) OR ([PersonnelId]  IS NULL AND [ShowroomId] IS NOT NULL)),
    CONSTRAINT CK_Commande_TypeDeCommande CHECK ([TypeDeCommande] = 'Client' OR [TypeDeCommande] = 'Fournisseur' OR [TypeDeCommande] ='Devis')
)
