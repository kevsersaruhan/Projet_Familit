CREATE PROCEDURE [dbo].[SP_Categorie_Add]
	@Nom NVARCHAR(20),
  @Details NTEXT
AS
	INSERT INTO [Categories] ([Nom],[Details]) OUTPUT inserted.Id VALUES (@Nom,@Details)
RETURN 0
