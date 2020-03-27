CREATE PROCEDURE [dbo].[SP_Product_Add]
	@nom NVARCHAR(30),
  @prix Float,
  @prixDAchatHTVA Float,
  @TVA Float,
  @nbPiece int,
  @details NTEXT,
  @catId int,
  @clientId int
AS
	INSERT INTO Product ([Nom],[Prix],[PrixDAchatHTVA],[TVA],[NbPiece],[Details],[CategorieId],[ClientId])
  OUTPUT INSERTED.Id
  VALUES(@nom,@prix,@prixDAchatHTVA,@TVA,@nbPiece,@details,@catId,@clientId)


RETURN 0
