CREATE PROCEDURE [dbo].[SP_Caracteristique_GetByCategorie]
	@id int
AS
	SELECT * FROM CaracteristiqueView
  WHERE CategorieId = @id
