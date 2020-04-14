CREATE PROCEDURE [dbo].[SP_Product_Caracteristique_Delete]
@idproduct int,
@idCaract int
AS
DELETE FROM [Product_Caracteristique] WHERE ProductId = @idproduct AND CaracteristiqueId=@idCaract
