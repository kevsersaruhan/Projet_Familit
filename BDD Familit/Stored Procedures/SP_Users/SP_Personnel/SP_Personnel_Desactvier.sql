CREATE PROCEDURE [dbo].[SP_Personnel_Desactvier]
	@id int
AS
		UPDATE Personnel SET [IsActif] = 0 WHERE Id = @id
