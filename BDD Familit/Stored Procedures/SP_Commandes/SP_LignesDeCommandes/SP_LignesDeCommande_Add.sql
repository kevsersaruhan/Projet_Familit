CREATE PROCEDURE [dbo].[SP_LignesDeCommande_Add]
	@Total float,
  @quantite int,
  @HTVA float,
  @TVAC float,
  @ProductID int,
  @CommandeId int,
  @productName nchar(100)
AS
	INSERT INTO LignesDeCommandes ([ProductName],[Quantite],[HTVA],[TVAC],[ProductId],[CommandeId]) OUTPUT INSERTED.Id
  VALUES (@productName,@Total,@quantite,@HTVA,@TVAC,@ProductID,@CommandeId)
RETURN 0
