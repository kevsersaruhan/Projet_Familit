CREATE PROCEDURE [dbo].[SP_Caracteristique_GetAll]
	
AS
	SELECT c.Nom, c.Details, c.CategorieId, cat.Nom FROM Caracteristique c
  INNER JOIN Categories cat
  ON c.CategorieId = cat.Id

RETURN 0
