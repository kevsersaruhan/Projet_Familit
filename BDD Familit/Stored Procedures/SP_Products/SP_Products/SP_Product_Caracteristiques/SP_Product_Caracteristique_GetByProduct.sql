CREATE PROCEDURE [dbo].[SP_Product_Caracteristique_GetByProduct]
		@idproduct int
AS
	SELECT c.CategorieId , c.Details, c.Nom, c.Id FROM [Product_Caracteristique] p INNER JOIN Caracteristique c on p.CaracteristiqueId = c.Id WHERE ProductId = @idproduct

