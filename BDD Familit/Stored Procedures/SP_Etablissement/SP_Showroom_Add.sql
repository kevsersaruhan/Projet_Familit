CREATE PROCEDURE [dbo].[SP_Showroom_Add]
	@nom NVARCHAR(60),
  @numBCE NVARCHAR(12),
  @adresseId int,
  @isActif bit

AS
	INSERT INTO Showroom([Nom],[NumBCE],[AdresseId],[IsActif])
  OUTPUT inserted.Id
  VALUES (@nom,@numBCE,@adresseId,@isActif)

