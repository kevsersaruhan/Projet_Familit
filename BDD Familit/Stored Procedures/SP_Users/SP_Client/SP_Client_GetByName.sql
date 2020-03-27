CREATE PROCEDURE [dbo].[SP_Client_GetByName]
	@nom NVARCHAR(60)
	AS
SELECT c.Nom, c.Prenom, c.Login, c.AdresseId, c.NumBCE, c.AdresseID, a.AdRue,a.AdNum, a.AdCp, a.AdVille, a.AdPays, a.NumTel, a.EMail
FROM Client c
INNER JOIN Adresse a
ON c.AdresseId = a.Id
WHERE c.Nom = @nom
