CREATE PROCEDURE [dbo].[SP_Categorie_Add]
	@Nom NVARCHAR(20),
  @Details NTEXT,
  @isActif bit
AS
	INSERT INTO [Categories] ([Nom],[Details],[IsActif]) OUTPUT inserted.Id VALUES (@Nom,@Details,@isActif)

