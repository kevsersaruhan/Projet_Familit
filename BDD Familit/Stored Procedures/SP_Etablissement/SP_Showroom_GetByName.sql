CREATE PROCEDURE [dbo].[SP_Showroom_GetByName]
@nom NVARCHAR(60)
AS
  DECLARE @AdresseId int
	SELECT  @AdresseId=AdresseId  FROM Showroom WHERE nom = @nom
  SELECT Nom,NumBCE FROM Showroom WHERE nom =@nom
  EXEC SP_Adresse_GetAllById @AdresseId

RETURN 0
