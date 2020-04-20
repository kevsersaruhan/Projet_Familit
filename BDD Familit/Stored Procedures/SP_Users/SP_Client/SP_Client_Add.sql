CREATE PROCEDURE [dbo].[SP_Client_Add]
  @nom NVARCHAR(60),
  @Prenom NVARCHAR(60),
  @login NVARCHAR (60) ,
  @Password NVARCHAR (60) ,
  @NumBCE NVARCHAR(12),
  @EstFournisseur BIT,
  @AdresseId int,
  @isActif bit

AS
 
  
  DECLARE @varbinarypwd varbinary(64);
  SELECT @varbinarypwd =CONVERT(varbinary(64), [dbo].SF_HashPassword(@Password))
	INSERT INTO Client([Nom],[Prenom],[Login],[Password],[AdresseId],[NumBCE],[EstFournisseur],[IsActif])
  OUTPUT inserted.Id
  VALUES (@nom,@Prenom,@login,@varbinarypwd,@adresseId,@NumBCE,@EstFournisseur,@isActif)

