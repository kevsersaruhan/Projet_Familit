CREATE PROCEDURE [dbo].[SP_Product_GetByName]
	@nom NVARCHAR(30)
  AS
  SELECT * FROM ProduitCategorie
  WHERE Nom =  @nom
