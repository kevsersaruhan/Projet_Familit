CREATE PROCEDURE [dbo].[SP_Commande_GetCommandeClient]
	@id int
AS
 SELECT * FROM Commande WHERE ClientId=@id

RETURN 0
