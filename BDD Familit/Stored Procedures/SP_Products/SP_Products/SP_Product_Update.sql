CREATE PROCEDURE [dbo].[SP_Product_Update]
@id int,
@nom NVARCHAR(30),
  @prix Float,
  @prixDAchatHTVA Float,
  @TVA Float,
  @nbPiece int,
  @details NTEXT,
  @catId int,
  @clientId int
AS
	UPDATE [Product] SET [Nom] = @nom, [Prix]= @prix, [PrixDAchatHTVA]=@prixDAchatHTVA,[TVA]=@TVA,[NbPiece]=@nbPiece,[Details]=@details,
  [CategorieId]=@catId,[ClientId]=@clientId
  WHERE Id = @id

RETURN 0
