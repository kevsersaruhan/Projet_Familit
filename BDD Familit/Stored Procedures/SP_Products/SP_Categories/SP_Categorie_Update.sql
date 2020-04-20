CREATE PROCEDURE [dbo].[SP_Categorie_Update]
	@id int,
  @nom NVARCHAR(20),
  @details NTEXT,
  @isActif bit
AS
	UPDATE Categories SET [Nom]=@nom,[Details]=@details, [isActif]=@isActif WHERE Id = @id
RETURN 0
