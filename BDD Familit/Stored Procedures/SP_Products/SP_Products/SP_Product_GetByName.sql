CREATE PROCEDURE [dbo].[SP_Product_GetByName]
	@nom NVARCHAR(30)
  AS
  SELECT p.Nom, p.Prix, p.PrixDAchatHTVA, p.TVA, p.Details, p.CategorieId, p.ClientId, p.NbPiece, c.Nom, cat.Nom FROM Product p
  INNER JOIN Client c
  ON c.Id = p.CategorieId
  INNER JOIN Categories cat
  ON p.CategorieId = cat.Id
  WHERE p.Nom =  @nom