CREATE PROCEDURE [dbo].[SP_Client_Add]
  @nom NVARCHAR(60),
  @Prenom NVARCHAR(60),
  @login NVARCHAR (60) ,
  @Password NVARCHAR(60) ,
  @NumBCE NVARCHAR(12),
  @EstFournisseur BIT,
  @adRue NVARCHAR(60),
	@adNum NVARCHAR(6),
  @adCp int,
  @adVille NVARCHAR(60),
  @adPays NVARCHAR(60),
  @email NVARCHAR(60),
  @numTel int,
  @isActif bit

AS
  IF @Password IS NOT NULL BEGIN SET @Password = [dbo].SF_HashPassword(@Password) END
  DECLARE @adresseId int
  EXEC @adresseId = [dbo].SP_Adresse_Add @adRue,@adNum,@adCp,@adVille,@adPays,@numTel,@email
	INSERT INTO Client([Nom],[Prenom],[Login],[PAssword],[AdresseId],[NumBCE],[EstFournisseur],[IsActif])
  OUTPUT inserted.Id
  VALUES (@nom,@Prenom,@login,@Password,@adresseId,@NumBCE,@EstFournisseur,@isActif)

