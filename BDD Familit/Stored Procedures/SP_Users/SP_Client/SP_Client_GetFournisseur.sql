CREATE PROCEDURE [dbo].[SP_Client_GetFournisseur]

AS
	SELECT * From ClientAdresse Where [EstFournisseur] = 1

