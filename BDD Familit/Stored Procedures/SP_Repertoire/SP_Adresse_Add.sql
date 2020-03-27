CREATE PROCEDURE [dbo].[SP_Adresse_Add]
	@adRue NVARCHAR(60),
	@adNum NVARCHAR(6),
  @adCp int,
  @adVille NVARCHAR(60),
  @adPays NVARCHAR(60),
  @email NVARCHAR(60),
  @numTel int
AS
	INSERT  INTO Adresse ([AdRue],[AdNum],[AdCp],[AdVille],[AdPays],[NumTel],[EMail])
  VALUES (@adRue,@adNum,@adCp,@adVille,@adPays,@numTel,@email)
  DECLARE @AdresseId int = SCOPE_IDENTITY()
RETURN @AdresseId
