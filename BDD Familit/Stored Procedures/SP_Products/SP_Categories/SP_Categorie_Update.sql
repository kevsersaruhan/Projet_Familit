CREATE PROCEDURE [dbo].[SP_Categorie_Update]
	@id int,
  @nom NVARCHAR(20),
  @details NTEXT
AS
	UPDATE Categories SET [Nom]=@nom,[Details]=@details WHERE Id = @id
RETURN 0
