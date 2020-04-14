CREATE PROCEDURE [dbo].[SP_Product_Desactiver]
		@id int
AS
		UPDATE Product SET [IsActif] = 0 WHERE Id = @id
