CREATE PROCEDURE [dbo].[SP_Personnel_Add]
	@nom NVARCHAR(60),
  @Prenom NVARCHAR(60),
  @dateDeNaissance Date,
  @Login NVARCHAR (60),
  @Password NVARCHAR (60),
  @Function NVARCHAR(60),
  @IsAdmin Bit,
  @DateDengagement Date,
  @NbJourAbsence int = 0,
  @NbJourVacances int =0,
  @Salaire float,
  @ShowroomId int,
  @AdresseId int,
  @isActif bit
AS
	
  INSERT INTO Personnel
  ([Nom],[Prenom],[DateDeNaissance],[Login],[Password], [Fonction], [IsAdmin], [DateDEngagement], [NbJourAbsence], [NbJourVacances], [Salaire], [AdresseId],[ShowroomId],[IsActif])
  OUTPUT inserted.Id
  VALUES (@nom,@Prenom,@dateDeNaissance,@Login,[dbo].SF_HashPassword(@Password),@Function,@IsAdmin,@DateDengagement,@NbJourAbsence, @NbJourVacances, @Salaire,@AdresseId,@ShowroomId,@isActif)



