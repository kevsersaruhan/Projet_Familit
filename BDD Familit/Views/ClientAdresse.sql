CREATE VIEW [dbo].[ClientAdresse]
	AS
  SELECT
  c.Id as ClientID,
  c.Nom,
  c.Prenom,
  c.Login,
  c.IsActif,
  c.AdresseId,
  c.NumBCE,
  a.AdRue,
  a.AdNum,
  a.AdCp,
  a.AdVille,
  a.AdPays,
  a.NumTel,
  a.EMail
FROM Client c
INNER JOIN Adresse a
ON c.AdresseId = a.Id
