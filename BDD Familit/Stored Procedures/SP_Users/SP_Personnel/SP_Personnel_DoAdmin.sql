CREATE PROCEDURE [dbo].[SP_Personnel_DoAdmin]
	@Id int
AS
	UPDATE Personnel SET [IsAdmin] = 1 WHERE Id = @Id
