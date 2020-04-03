CREATE PROCEDURE [dbo].[SP_Showroom_Delete]
	@id int
AS
 DECLARE @AdresseId int
 SELECT @AdresseId = AdresseId FROM Showroom Where Id = @id
 EXEC [dbo].[SP_Adresse_Delete] @AdresseId
 DELETE FROM Showroom WHere Id = @id
