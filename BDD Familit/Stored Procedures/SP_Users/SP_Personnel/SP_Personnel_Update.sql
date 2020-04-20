CREATE PROCEDURE [dbo].[SP_Personnel_Update]
  @nom NVARCHAR(60),
  @Prenom NVARCHAR(60),
  @dateDeNaissance Date,
  @login NVARCHAR (60),
  @Function NVARCHAR(60),
  @IsAdmin Bit,
  @DateDengagement Date,
  @NbJourAbsence int = 0,
  @NbJourVacances int =0,
  @Salaire float,
  @ShowroomId int,
  @adresseId int,
  @id int,
  @IsActif bit

AS

	UPDATE [Personnel] SET [Nom]=@nom,[Prenom]=@Prenom,[DateDeNaissance]=@dateDeNaissance,[Login]=@login, [Fonction]=@Function, [IsAdmin]=@IsAdmin,
                         [DateDEngagement]=@DateDengagement,[NbJourAbsence]=@NbJourAbsence, [NbJourVacances]=@NbJourAbsence, [Salaire]=@Salaire,
                         [AdresseId]=@adresseId,[ShowroomId]=@ShowroomId,[IsActif]=@IsActif
                     WHERE Id =@id


