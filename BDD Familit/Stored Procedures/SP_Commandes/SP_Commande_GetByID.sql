CREATE PROCEDURE [dbo].[SP_Commande_GetByID]
@id int
	AS
  SELECT * FROM Commande WHERE Id=@id
