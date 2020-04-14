CREATE PROCEDURE [dbo].[SP_Client_Activer]
	@id int
AS
		UPDATE Client SET [IsActif] = 1 WHERE Id = @id
