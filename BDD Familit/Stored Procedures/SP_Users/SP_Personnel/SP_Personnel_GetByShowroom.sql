CREATE PROCEDURE [dbo].[SP_Personnel_GetByShowroom]
	@idshowroom int
  AS
SELECT * FROM PersonnelShowroom Where ShowroomID = @idshowroom 
