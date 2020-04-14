CREATE PROCEDURE [dbo].[SP_Product_Caracteristique_GetByCaracteristique]
	@idcarcat int
AS
	SELECT ProductId FROM [Product_Caracteristique] WHERE CaracteristiqueId = @idcarcat

