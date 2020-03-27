CREATE PROCEDURE [dbo].[SP_Caracteristique_Add]
	@nom NVARCHAR(20),
  @details NTEXT,
  @Categorie int
AS
	INSERT INTO Caracteristique (Nom,Details,CategorieId) OUTPUT INSERTED.Id VALUES (@nom,@details,@Categorie)
RETURN 0

