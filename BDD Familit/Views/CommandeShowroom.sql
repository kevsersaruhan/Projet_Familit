CREATE VIEW [dbo].[CommandeShowroom]
	AS

  SELECT [Id] ,
    [DateCommande],
    [Total],
    [Acompte], 
    [Solde], 
    [MoyenDePaiement], 
    [Statut], 
    [Livraison], 
    [DateDeLivraison], 
    [TypeDeCommande], 
    [ClientId], 
    [PersonnelId], 
    c.[ShowroomID] AS ComShowroom,
    s.ShowroomId AS IDShowroom,
    Nom,
    NumBCE,
    IsActif,
    AdresseId,
    AdRue,
    AdNum,
    AdCp,
    AdVille,
    AdPays,
    NumTel,
    Email
    FROM Commande c INNER JOIN ShowroomAdresse s ON c.ShowroomID = s.ShowroomId 
