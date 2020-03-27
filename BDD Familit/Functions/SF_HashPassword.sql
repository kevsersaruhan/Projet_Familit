CREATE FUNCTION [dbo].[SF_HashPassword]
(
	@password NVARCHAR(50)
)
RETURNS VARBINARY(32)
AS
BEGIN
	DECLARE @passPlusNoise NVARCHAR(MAX)
	SET @passPlusNoise = 'Fam' + @password + 'Ilit61'
	RETURN HASHBYTES(N'SHA2_256',@passPlusNoise)
END
