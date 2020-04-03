CREATE PROCEDURE [dbo].[SP_Client_Delete]
		@id int
AS
  DECLARE @AdresseId int
  SELECT @AdresseId = AdresseId FROM Client Where Id = @id
  EXEC [dbo].[SP_Adresse_Delete] @AdresseId
	DELETE FROM Client WHERE Id = @id


