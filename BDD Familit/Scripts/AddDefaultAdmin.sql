
IF EXISTS(SELECT [Id] FROM [Personnel] WHERE [Login] = 'Admin' AND [Password] = dbo.SF_HashPassword('Admin'))
	BEGIN
		DELETE FROM [Personnel] WHERE [Login] = 'Admin' AND [Password] = dbo.SF_HashPassword('Admin');
	END
  INSERT  INTO Adresse ([AdRue],[AdNum],[AdCp],[AdVille],[AdPays],[NumTel],[EMail])
  VALUES ('Avenue Wilson','553',7012,'Jemappes','Belgique',0472851684,'familitsprl@gmail.com')
  DECLARE @AdresseId1 int = SCOPE_IDENTITY()
  INSERT INTO Showroom([Nom],[NumBCE],[AdresseId],[IsActif])
  VALUES ('Familit','BE0849779485',@AdresseId1,1)
  DECLARE @ShowroomId int =SCOPE_IDENTITY()
   INSERT  INTO Adresse ([AdRue],[AdNum],[AdCp],[AdVille],[AdPays],[NumTel],[EMail])
  VALUES ('Rue de Mons','61/011',6030,'Marchienne','Belgique',0489805351,'musadanur@gmail.com')
  DECLARE @AdresseId int = SCOPE_IDENTITY()
  INSERT INTO Personnel
  ([Nom],[Prenom],[DateDeNaissance],[Login],[Password], [Fonction], [IsAdmin], [DateDEngagement], [NbJourAbsence], [NbJourVacances], [Salaire], [AdresseId],[ShowroomId],[IsActif])
  OUTPUT inserted.Id
  VALUES ('Adanur','Musa','1987.08.13','Admin',[dbo].SF_HashPassword('Admin'),'Gerant',1,'2013.07.01',0, 0, 0,@AdresseId,@ShowroomId,1)

GO

