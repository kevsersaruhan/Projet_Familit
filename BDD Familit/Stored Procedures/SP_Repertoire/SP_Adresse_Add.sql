CREATE PROCEDURE [dbo].[SP_Adresse_Add]
	@adRue NVARCHAR(60),
	@adNum NVARCHAR(6),
  @adCp int,
  @adVille NVARCHAR(60),
  @adPays NVARCHAR(60),
  @email NVARCHAR(60),
  @numTel int,
  @id int output
AS
SET @id =0
	INSERT  INTO Adresse ([AdRue],[AdNum],[AdCp],[AdVille],[AdPays],[NumTel],[EMail])
  OUTPUT   inserted.Id
  VALUES (@adRue,@adNum,@adCp,@adVille,@adPays,@numTel,@email)
  SET @id = SCOPE_IDENTITY()
RETURN @id
