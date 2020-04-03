CREATE PROCEDURE [dbo].[SP_Client_GetByID]
	@id int
	AS
SELECT * FROM ClientAdresse
WHERE ClientID = @id
