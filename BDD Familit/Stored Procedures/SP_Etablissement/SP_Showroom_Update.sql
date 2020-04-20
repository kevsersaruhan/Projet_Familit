CREATE PROCEDURE [dbo].[SP_Showroom_Update]
	@nom NVARCHAR(60),
  @numBCE NVARCHAR(12),
  @adresseId int,
  @id int,
  @IsActif bit

AS
	UPDATE [Showroom] SET [Nom]=@nom,[NumBCE]=@numBCE,[AdresseId]=@adresseId,[IsActif]=IsActif WHERE Id =@id

