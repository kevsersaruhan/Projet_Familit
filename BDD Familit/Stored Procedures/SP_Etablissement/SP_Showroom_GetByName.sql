CREATE PROCEDURE [dbo].[SP_Showroom_GetByName]
@nom NVARCHAR(60)
AS
  SELECT * FROM ShowroomAdresse
  WHERE Nom = @nom
