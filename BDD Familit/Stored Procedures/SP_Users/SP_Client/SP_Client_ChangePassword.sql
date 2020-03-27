CREATE PROCEDURE [dbo].[SP_Client_ChangePassword]
	@id INT,
	@password NVARCHAR(50)
AS
	UPDATE Client
		SET [Password] = [dbo].SF_HashPassword(@password)
	WHERE Id = @id

