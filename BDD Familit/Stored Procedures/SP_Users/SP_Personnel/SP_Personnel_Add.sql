CREATE PROCEDURE [dbo].[SP_Personnel_Add]
	@nom NVARCHAR(60),
  @Prenom NVARCHAR(60),
  @dateDeNaissance Date,
  @Login NVARCHAR (60),
  @Password NVARCHAR(60),
  @Function NVARCHAR(60),
  @IsAdmin Bit,
  @DateDengagement Date,
  @NbJourAbsence int = 0,
  @NbJourVacances int =0,
  @Salaire float,
  @ShowroomId int,
 	@adRue NVARCHAR(60),
	@adNum NVARCHAR(6),
  @adCp int,
  @adVille NVARCHAR(60),
  @adPays NVARCHAR(60),
  @email NVARCHAR(60),
  @numTel int
AS
	DECLARE @AdresseId int
  EXEC @AdresseId = SP_Adresse_Add @adRue,@adNum,@adCp,@adVille,@adPays,@email,@numTel
  INSERT INTO Personnel
  ([Nom],[Prenom],[DateDeNaissance],[Login],[Password], [Fonction], [IsAdmin], [DateDEngagement], [NbJourAbsence], [NbJourVacances], [Salaire], [AdresseId],[ShowroomId])
  OUTPUT inserted.Id
  VALUES (@nom,@Prenom,@dateDeNaissance,@Login,[dbo].SF_HashPassword(@Password),@IsAdmin,@DateDengagement,@NbJourAbsence, @NbJourVacances, @Salaire,@AdresseId,@ShowroomId)
RETURN 0


