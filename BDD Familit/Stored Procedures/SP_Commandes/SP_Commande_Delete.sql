CREATE PROCEDURE [dbo].[SP_Commande_Delete]
@id int
	AS
  DELETE FROM Commande WHERE Id = @id
