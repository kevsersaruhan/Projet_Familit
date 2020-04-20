CREATE PROCEDURE [dbo].[SP_Product_GetById]
	@id int
  AS
  SELECT * from Product WHERE Id=@id
