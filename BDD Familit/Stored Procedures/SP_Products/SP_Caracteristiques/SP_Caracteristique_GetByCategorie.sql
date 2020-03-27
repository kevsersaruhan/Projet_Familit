CREATE PROCEDURE [dbo].[SP_Caracteristique_GetByCategorie]
	@id int
AS
	SELECT c.Nom, c.Details, c.CategorieId, cat.Nom FROM Caracteristique c
  INNER JOIN Categories cat
  ON c.CategorieId = cat.Id
  WHERE CategorieId = @id
