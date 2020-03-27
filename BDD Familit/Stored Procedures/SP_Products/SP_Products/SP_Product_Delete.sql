CREATE PROCEDURE [dbo].[SP_Product_Delete]
	@id int
AS
	DELETE FROM Product WHERE Id=@id
RETURN 0
