CREATE PROCEDURE [dbo].[SP_Personnel_Actvier]
	@id int
AS
		UPDATE Personnel SET [IsActif] = 1 WHERE Id = @Id
