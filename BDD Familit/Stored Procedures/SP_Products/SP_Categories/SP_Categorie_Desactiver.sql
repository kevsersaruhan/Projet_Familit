CREATE PROCEDURE [dbo].[SP_Categorie_Desactiver]
	@id int
AS
		UPDATE Categories SET [IsActif] = 0 WHERE Id = @Id
