CREATE PROCEDURE [dbo].[SP_LignesDeCommande_Update]
	@Total float,
  @quantite int,
  @HTVA float,
  @TVAC float,
  @ProductID int,
  @CommandeId int,
  @id int
AS
	UPDATE [LignesDeCommandes] SET [Total]=@Total,[Quantite]=@quantite,[HTVA]=@HTVA,[TVAC]=@TVAC,[ProductId]=@ProductID,[CommandeId]=@CommandeId
  WHERE Id=@id
RETURN 0
