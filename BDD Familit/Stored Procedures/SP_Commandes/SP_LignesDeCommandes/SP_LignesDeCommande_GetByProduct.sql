CREATE PROCEDURE [dbo].[SP_LignesDeCommande_GetByProduct]
	@idProduct int
AS
	SELECT * FROM LignesDeCommandes WHERE ProductId = @idProduct
RETURN 0
