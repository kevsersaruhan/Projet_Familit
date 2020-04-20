CREATE PROCEDURE [dbo].[SP_Personnel_Activer]
	@id int
AS
		UPDATE Personnel SET [IsActif] = 1 WHERE Id = @id
