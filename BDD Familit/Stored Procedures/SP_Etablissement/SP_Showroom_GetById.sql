CREATE PROCEDURE [dbo].[SP_Showroom_GetById]
	@id int
AS
  SELECT * FROM ShowroomAdresse
  WHERE ShowroomId= @id

