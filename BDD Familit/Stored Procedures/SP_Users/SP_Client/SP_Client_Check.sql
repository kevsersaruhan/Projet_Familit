CREATE PROCEDURE [dbo].[SP_Client_Check]
	@login NVARCHAR(50),
	@password NVARCHAR(50),
	@clientId INT OUTPUT
AS
	SET @clientId = 0;
	IF EXISTS (SELECT Id FROM Client WHERE [Login] = @login AND [Password] = dbo.SF_HashPassword(@password))
		SELECT @clientId = Id FROM Client WHERE [Login] = @login


