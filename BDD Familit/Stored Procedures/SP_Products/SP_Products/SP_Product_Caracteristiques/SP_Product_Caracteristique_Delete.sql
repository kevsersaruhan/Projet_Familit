CREATE PROCEDURE [dbo].[SP_Product_Caracteristique_Delete]
@idproduct int
AS
DELETE FROM [Product_Caracteristique] WHERE ProductId = @idproduct
RETURN 0
