CREATE PROCEDURE [dbo].[SP_Personnel_ChangePassword]
	@id INT,
	@password NVARCHAR (60)
AS
	UPDATE Personnel
		SET [Password] = [dbo].SF_HashPassword(@password)
	WHERE Id = @id
