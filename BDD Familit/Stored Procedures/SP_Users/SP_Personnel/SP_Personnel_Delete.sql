CREATE PROCEDURE [dbo].[SP_Personnel_Delete]
	@id int
AS
  DECLARE @AdresseId int
  SELECT @AdresseId = AdresseId FROM Personnel Where Id = @id
  EXEC [dbo].[SP_Adresse_Delete] @AdresseId
	DELETE FROM Personnel WHERE Id = @id

