CREATE PROCEDURE [dbo].[SP_Client_GetByID]
	@id int
	AS
SELECT c.Nom, c.Prenom, c.Login, c.AdresseId, c.NumBCE, c.AdresseID, a.AdRue,a.AdNum, a.AdCp, a.AdVille, a.AdPays, a.NumTel, a.EMail
FROM Client c
INNER JOIN Adresse a
ON c.AdresseId = a.Id
WHERE c.Id = @id
