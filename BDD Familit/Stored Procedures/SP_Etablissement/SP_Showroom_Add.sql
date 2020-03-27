CREATE PROCEDURE [dbo].[SP_Showroom_Add]
	@nom NVARCHAR(60),
  @numBCE NVARCHAR(12),
  @adRue NVARCHAR(60),
	@adNum NVARCHAR(6),
  @adCp int,
  @adVille NVARCHAR(60),
  @adPays NVARCHAR(60),
  @email NVARCHAR(60),
  @numTel int

AS
  DECLARE @adresseId int
  EXEC @adresseId = [dbo].SP_Adresse_Add @adRue,@adNum,@adCp,@adVille,@adPays,@numTel,@email
	INSERT INTO Showroom([Nom],[NumBCE],[AdresseId])
  OUTPUT inserted.Id
  VALUES (@nom,@numBCE,@adresseId)
RETURN 0
