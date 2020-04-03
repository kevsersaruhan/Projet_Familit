CREATE PROCEDURE [dbo].[SP_Client_Product_Add]
	@idclient int,
	@idproduct int
AS
	INSERT INTO [Client_Product]([ProductId],[ClientId]) OUTPUT INSERTED.Id VALUES(@idclient,@idproduct)

