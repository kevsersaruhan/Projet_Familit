CREATE PROCEDURE [dbo].[SP_Client_Product_Fav]
	@idclient int
AS
	SELECT ProductId FROM Client_Product c INNER JOIN Product p ON ProductId = p.Id WHERE c.ClientId=@idclient
RETURN 0
