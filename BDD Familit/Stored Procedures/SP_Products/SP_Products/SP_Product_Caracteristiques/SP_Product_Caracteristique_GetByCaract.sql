CREATE PROCEDURE [dbo].[SP_Product_Caracteristique_GetByCaracteristique]
	@idcarcat int
AS
	SELECT p.Id, p.ClientId, p.CategorieId, p.ClientId, p.Details,p.IsActif,p.NbPiece,p.Nom,p.Prix,p.PrixDAchatHTVA FROM [Product_Caracteristique] c INNER JOIN Product p on c.ProductId = p.Id WHERE CaracteristiqueId = @idcarcat

