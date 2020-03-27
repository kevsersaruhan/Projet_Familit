CREATE PROCEDURE [dbo].[SP_Adresse_Delete]
	@id int
AS
	DELETE FROM Adresse WHERE Id = @id
RETURN 0
