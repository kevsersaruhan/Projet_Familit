CREATE PROCEDURE [dbo].[SP_Personnel_Desactiver]
	@id int
AS
		UPDATE Personnel SET [IsActif] = 0 WHERE Id = @id
