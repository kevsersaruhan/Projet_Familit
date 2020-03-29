CREATE PROCEDURE [dbo].[SP_LignesDeCommande_Update]
	@Total float,
  @quantite int,
  @HTVA float,
  @TVAC float,
  @ProductID int,
  @CommandeId int,
  @id int,
  @productName NChar(100)
AS
	UPDATE [LignesDeCommandes] SET [ProductName]=@productName,[Total]=@Total,[Quantite]=@quantite,[HTVA]=@HTVA,[TVAC]=@TVAC,[ProductId]=@ProductID,[CommandeId]=@CommandeId
  WHERE Id=@id
RETURN 0
