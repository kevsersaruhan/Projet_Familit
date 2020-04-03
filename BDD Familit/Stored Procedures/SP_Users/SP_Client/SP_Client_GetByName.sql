CREATE PROCEDURE [dbo].[SP_Client_GetByName]
	@nom NVARCHAR(60)
	AS
SELECT * FROM ClientAdresse
WHERE Nom = @nom
