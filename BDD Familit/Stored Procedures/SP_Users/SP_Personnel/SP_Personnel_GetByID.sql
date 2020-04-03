CREATE PROCEDURE [dbo].[SP_Personnel_GetByID]
	@id int
AS
SELECT * FROM PersonnelShowroom
WHERE PersonnelID=@id

