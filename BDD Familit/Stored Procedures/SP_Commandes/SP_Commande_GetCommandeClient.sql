CREATE PROCEDURE [dbo].[SP_Commande_GetCommandeClient]
	@id int
AS
 SELECT * FROM CommandeShowroom WHERE ClientId=@id

RETURN 0
