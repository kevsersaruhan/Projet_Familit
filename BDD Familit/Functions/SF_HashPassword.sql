CREATE FUNCTION [dbo].[SF_HashPassword]
(
	@password NVARCHAR(50)
)
RETURNS VARBINARY(64)
AS
BEGIN
	DECLARE @passPlusNoise NVARCHAR(MAX)
	SET @passPlusNoise = 'Fam' + @password + 'Ilit61'
	RETURN HASHBYTES(N'SHA2_512',@passPlusNoise)
END
