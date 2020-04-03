CREATE PROCEDURE [dbo].[SP_Categorie_Activer]
	@id int
AS
		UPDATE Categories SET [IsActif] = 1 WHERE Id = @Id
