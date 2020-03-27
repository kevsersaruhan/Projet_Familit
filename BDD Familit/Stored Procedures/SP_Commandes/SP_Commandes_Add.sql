CREATE PROCEDURE [dbo].[SP_Commandes_Add]
	@DateDecommande Date,
  @Total Decimal,
  @Acompte decimal,
  @Solde decimal,
  @MoyenDePaiement NVARCHAR(10),
  @Statut NVARCHAR(10),
  @Livraison Bit,
  @DateDeLivraison Date,
  @TypeDecommande NVARCHAR(30),
  @ClientId int,
  @PersonnelId int,
  @showroomId int
AS
	INSERT INTO Commande ([DateCommande],[Total],[Acompte],[Solde],[MoyenDePaiement],[Statut],[Livraison],[DateDeLivraison],[TypeDeCommande],[ClientId],
  [PersonnelId],[ShowroomID]) OUTPUT INSERTED.Id VALUES(@DateDecommande,@Total,@Acompte,@Solde,@MoyenDePaiement,@Statut,@Livraison,
  @DateDeLivraison,@TypeDecommande,@ClientId,@PersonnelId,@showroomId)
   
