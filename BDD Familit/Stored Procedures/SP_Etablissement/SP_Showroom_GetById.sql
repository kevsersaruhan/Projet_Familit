CREATE PROCEDURE [dbo].[SP_Showroom_GetById]
	@id int
AS
  SELECT Nom, NumBCE, AdresseID, AdRue,AdNum, AdCp, AdVille, AdPays, NumTel, Email
  FROM Showroom s
  JOIN Adresse a
  ON s.AdresseId = a.Id
  WHERE s.id = @id

RETURN 0
