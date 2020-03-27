CREATE PROCEDURE [dbo].[SP_Categorie_GetByName]
	@nom NVARCHAR(20)
AS
	SELECT * FROM Categories WHERE Nom = @nom
RETURN 0
