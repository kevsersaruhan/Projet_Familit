CREATE PROCEDURE [dbo].[SP_Personnel_UnsetAdmin]
	@id int
AS
	UPDATE Personnel SET [isAdmin] = 0 WHERE Id = @id
