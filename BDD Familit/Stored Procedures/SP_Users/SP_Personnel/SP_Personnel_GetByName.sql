CREATE PROCEDURE [dbo].[SP__Personnel_GetByName]
	@nom NVARCHAR(60)
AS
SELECT * FROM PersonnelShowroom WHERE Nom = @nom
