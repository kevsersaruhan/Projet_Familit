CREATE PROCEDURE [dbo].[SP_Showroom_Desactiver]
	@id int
AS
		UPDATE Showroom SET [IsActif] = 0 WHERE Id = @Id

