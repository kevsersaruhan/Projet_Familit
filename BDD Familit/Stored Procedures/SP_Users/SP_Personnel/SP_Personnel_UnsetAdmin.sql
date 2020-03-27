CREATE PROCEDURE [dbo].[SP_Personnel_UnsetAdmin]
	@Id int
AS
	UPDATE Personnel SET [isAdmin] = 0 WHERE Id = @Id
