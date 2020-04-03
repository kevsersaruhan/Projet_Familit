CREATE PROCEDURE [dbo].[SP_Client_Product_Delete]
	@id int
AS
	DELETE FROM [Client_Product] WHERE Id=@id

