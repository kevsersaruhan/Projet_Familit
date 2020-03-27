CREATE PROCEDURE [dbo].[SP_LignesDeCommande_Delete]
	@id int
AS
	DELETE FROM LignesDeCommandes WHERE Id=@id
RETURN 0
