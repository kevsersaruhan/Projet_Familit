CREATE PROCEDURE [dbo].[SP_Personnel_Update]
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
  @adresseId int,
 	@adRue NVARCHAR(60),
	@adNum NVARCHAR(6),
  @adCp int,
  @adVille NVARCHAR(60),
  @adPays NVARCHAR(60),
  @email NVARCHAR(60),
  @numTel int,
  @id int

AS
  EXEC [dbo].SP_Adresse_Update @adRue, @adNum, @adCp, @adVille, @adPays,@email, @numTel, @adresseId
	UPDATE [Personnel] SET [Nom]=@nom,[Prenom]=@Prenom,[DateDeNaissance]=@dateDeNaissance,[Login]=@login,
                         [Password]=[dbo].SF_HashPassword(@Password), [Fonction]=@Function, [IsAdmin]=@IsAdmin,
                         [DateDEngagement]=@DateDengagement,[NbJourAbsence]=@NbJourAbsence, [NbJourVacances]=@NbJourAbsence, [Salaire]=@Salaire,
                         [AdresseId]=@adresseId,[ShowroomId]=@ShowroomId
                     WHERE Id =@id
RETURN 0

