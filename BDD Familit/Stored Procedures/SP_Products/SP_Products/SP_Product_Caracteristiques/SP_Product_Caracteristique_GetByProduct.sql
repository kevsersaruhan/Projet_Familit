CREATE PROCEDURE [dbo].[SP_Product_Caracteristique_GetByProduct]
		@idproduct int
AS
	SELECT * FROM [Product_Caracteristique] WHERE ProductId = @idproduct
RETURN 0
RETURN 0
