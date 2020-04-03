CREATE PROCEDURE [dbo].[SP_Product_Activer]
	@id int
AS
		UPDATE Product SET [IsActif] = 1 WHERE Id = @Id
