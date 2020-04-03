CREATE PROCEDURE [dbo].[SP_Showroom_Update]
	@nom NVARCHAR(60),
  @numBCE NVARCHAR(12),
  @adRue NVARCHAR(60),
	@adNum NVARCHAR(6),
  @adCp int,
  @adVille NVARCHAR(60),
  @adPays NVARCHAR(60),
  @email NVARCHAR(60),
  @numTel int,
  @adresseId int,
  @id int,
  @IsActif bit

AS
  EXEC [dbo].SP_Adresse_Update @adRue, @adNum, @adCp, @adVille, @adPays,@email, @numTel, @adresseId
	UPDATE [Showroom] SET [Nom]=@nom,[NumBCE]=@numBCE,[AdresseId]=@adresseId,[IsActif]=IsActif WHERE Id =@id

