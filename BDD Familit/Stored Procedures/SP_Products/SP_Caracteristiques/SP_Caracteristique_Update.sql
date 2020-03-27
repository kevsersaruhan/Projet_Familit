CREATE PROCEDURE [dbo].[SP_Caracteristique_Update]
	@id int,
  @nom NVARCHAR(20),
  @details NTEXT,
  @categorieId int
  AS
  UPDATE Caracteristique SET [Nom]=@nom, [Details]=@details, [CategorieId]=@categorieId WHERE Id=@id
