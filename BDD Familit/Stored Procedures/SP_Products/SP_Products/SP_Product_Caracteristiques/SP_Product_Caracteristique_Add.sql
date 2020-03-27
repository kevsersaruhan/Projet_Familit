CREATE PROCEDURE [dbo].[SP_Product_Caracteristique_Add]
	@idProduct int,
  @idCaracteristique int,
  @valeur NVARCHAR(60)
AS
	INSERT INTO [Product_Caracteristique] ([ProductId],[CaracteristiqueId],[Valeur])
  OUTPUT INSERTED.Id
  VALUES (@idProduct,@idCaracteristique,@valeur)

RETURN 0
