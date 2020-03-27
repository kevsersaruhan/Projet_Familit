CREATE PROCEDURE [dbo].[SP_Product_Caracteristique]
	@idproduct int
AS
	SELECT productId, CaracteristiqueId, Valeur, c.Nom, c.Details from Product_Caracteristique
  INNER JOIN Caracteristique c
  ON c.Id = CaracteristiqueId
  INNER JOIN Product p
  ON p.Id = productId
