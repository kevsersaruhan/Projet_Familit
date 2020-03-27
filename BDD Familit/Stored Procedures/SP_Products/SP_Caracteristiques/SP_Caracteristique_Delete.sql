CREATE PROCEDURE [dbo].[SP_Caracteristique_Delete]
	@id int
  AS
  DELETE FROM Caracteristique WHERE Id = @id
RETURN 0
