CREATE PROCEDURE [dbo].[SP_Product_GetByFournisseur]
	@clientId int
AS
	SELECT * FROM ProduitCategorie
  WHERE ClientId = @clientId
