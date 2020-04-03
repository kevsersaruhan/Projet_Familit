CREATE PROCEDURE [dbo].[SP_Personnel_Check]
	@login NVARCHAR(50),
	@password NVARCHAR(50),
	@persoId INT OUTPUT
AS
	SET @persoId = 0;
	IF EXISTS (SELECT Id FROM Personnel WHERE [Login] = @login AND [Password] = dbo.SF_HashPassword(@password))
		SELECT @persoId = Id FROM Personnel WHERE [Login] = @login

