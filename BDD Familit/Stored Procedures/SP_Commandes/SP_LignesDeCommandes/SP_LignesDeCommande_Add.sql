CREATE PROCEDURE [dbo].[SP_LignesDeCommande_Add]
	@Total float,
  @quantite int,
  @HTVA float,
  @TVAC float,
  @ProductID int,
  @CommandeId int
AS
	INSERT INTO LignesDeCommandes ([Total],[Quantite],[HTVA],[TVAC],[ProductId],[CommandeId]) OUTPUT INSERTED.Id
  VALUES (@Total,@quantite,@HTVA,@TVAC,@ProductID,@CommandeId)
RETURN 0
