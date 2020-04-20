CREATE PROCEDURE [dbo].[SP_Client_Update]
	@nom NVARCHAR(60),
  @prenom NVARCHAR(60),
  @login NVARCHAR (60) = NULL,
  @NumBCE NVARCHAR(12) = NULL,
  @EstFournisseur BIT,
  @adresseId int,
  @id int,
  @isActif bit

AS

UPDATE [Client] SET [Nom]=@nom, [Prenom]=@prenom,[Login]=@login,
                    [NumBCE]=@NumBCE,[EstFournisseur]=@EstFournisseur,[AdresseId]=@adresseId,[IsActif]=@isActif
                WHERE Id=@id
