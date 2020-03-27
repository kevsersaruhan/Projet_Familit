CREATE PROCEDURE [dbo].[SP_Client_Update]
	@nom NVARCHAR(60),
  @Prenom NVARCHAR(60),
  @Login NVARCHAR (60) = NULL,
  @Password NVARCHAR(60) = NULL,
  @NumBCE NVARCHAR(12) = NULL,
  @EstFournisseur BIT,

  @adRue NVARCHAR(60),
	@adNum NVARCHAR(6),
  @adCp int,
  @adVille NVARCHAR(60),
  @adPays NVARCHAR(60),
  @email NVARCHAR(60),
  @numTel int,
  @adresseId int,
  @id int

AS
 EXEC [dbo].SP_Adresse_Update @adRue, @adNum, @adCp, @adVille, @adPays,@email, @numTel, @adresseId

UPDATE [Client] SET [Nom]=@nom, [Prenom]=@prenom,[Login]=@Login,[Password]=[dbo].SF_HashPassword(@password),
                    [NumBCE]=@NumBCE,[EstFournisseur]=@EstFournisseur,[AdresseId]=@adresseId
                WHERE Id=@id
