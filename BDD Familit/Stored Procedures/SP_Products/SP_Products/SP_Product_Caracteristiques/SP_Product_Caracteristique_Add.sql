CREATE PROCEDURE [dbo].[SP_Product_Caracteristique_Add]
	@idProduct int,
  @idCaracteristique int
AS
	INSERT INTO [Product_Caracteristique] ([ProductId],[CaracteristiqueId])
  OUTPUT INSERTED.Id
  VALUES (@idProduct,@idCaracteristique)
