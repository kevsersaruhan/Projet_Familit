CREATE PROCEDURE [dbo].[SP_Commandes_Update]
	@DateDecommande Date,
  @Total Decimal,
  @Acompte decimal,
  @Solde decimal,
  @MoyenDePaiement NVARCHAR(10),
  @statut NVARCHAR(10),
  @Livraison Bit,
  @DateDeLivraison Date,
  @TypeDecommande NVARCHAR(30),
  @ClientId int,
  @PersonnelId int,
  @showroomId int,
  @id int
AS
	UPDATE [Commande] SET [DateCommande]=@DateDecommande,[Total]=@total,[Acompte]=@Acompte,[Solde]=@Solde,[MoyenDePaiement]=@MoyenDePaiement,
                        [Statut]=@statut,[Livraison]=@Livraison,[DateDeLivraison]=@DateDeLivraison,[TypeDeCommande]=@TypeDecommande,[ClientId]=@ClientId,
                        [PersonnelId]=@PersonnelId,[ShowroomID]=@showroomId
                    WHERE [Id] = @id
RETURN 0
