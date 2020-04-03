CREATE PROCEDURE [dbo].[SP_Client_Desactiver]
	@id int
AS
		UPDATE Client SET [IsActif] = 0 WHERE Id = @Id
