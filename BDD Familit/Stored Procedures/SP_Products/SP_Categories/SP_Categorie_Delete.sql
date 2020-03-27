CREATE PROCEDURE [dbo].[SP_Categorie_Delete]
@id int
AS
DELETE FROM Categories WHERE Id = @id
RETURN 0
