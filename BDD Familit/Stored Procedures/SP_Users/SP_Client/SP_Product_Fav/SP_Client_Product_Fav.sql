CREATE PROCEDURE [dbo].[SP_Client_Product_Fav]
	@idclient int
AS
 SELECT ProductId FROM Client_Product c
 WHERE c.ClientId=@idclient

