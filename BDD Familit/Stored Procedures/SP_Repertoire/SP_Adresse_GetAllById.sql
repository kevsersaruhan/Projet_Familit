CREATE PROCEDURE [dbo].[SP_Adresse_GetAllById]
	@id int
AS
	SELECT * FROM Adresse Where Id=@id
RETURN 0
