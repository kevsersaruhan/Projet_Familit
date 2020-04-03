CREATE PROCEDURE [dbo].[SP_Showroom_Activer]
	@id int
AS
		UPDATE Showroom SET [IsActif] = 1 WHERE Id = @Id
