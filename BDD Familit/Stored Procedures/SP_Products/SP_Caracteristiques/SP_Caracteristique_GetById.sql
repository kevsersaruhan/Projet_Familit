CREATE PROCEDURE [dbo].[SP_Caracteristique_GetById]
 @id int

 AS

  SELECT * FROM CaracteristiqueView
  WHERE Id = @id
