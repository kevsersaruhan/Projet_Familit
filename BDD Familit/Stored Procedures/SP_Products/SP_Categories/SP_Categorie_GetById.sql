CREATE PROCEDURE [dbo].[SP_Categorie_GetById]
	@id int
AS
	SELECT * FROM Categories WHERE Id = @id
RETURN 0
