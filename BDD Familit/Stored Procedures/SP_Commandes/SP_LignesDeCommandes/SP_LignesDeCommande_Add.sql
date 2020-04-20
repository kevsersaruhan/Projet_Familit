CREATE PROCEDURE [dbo].[SP_LignesDeCommande_Add]
	@Total float,
  @quantite int,
  @HTVA float,
  @TVAC float,
  @ProductID int,
  @CommandeId int,
  @productName nvarchar(100)
AS
	INSERT INTO LignesDeCommandes ([ProductName],[Total],[Quantite],[HTVA],[TVAC],[ProductId],[CommandeId]) OUTPUT INSERTED.Id
  VALUES (@productName,@Total,@quantite,@HTVA,@TVAC,@ProductID,@CommandeId)
RETURN 0
