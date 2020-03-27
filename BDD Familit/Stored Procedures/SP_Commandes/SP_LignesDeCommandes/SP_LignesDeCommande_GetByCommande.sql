CREATE PROCEDURE [dbo].[SP_LignesDeCommande_GetByCommande]
	@idCommande int
  AS
  SELECT * FROM LignesDeCommandes WHERE CommandeId= @idCommande
RETURN 0
