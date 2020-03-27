CREATE PROCEDURE [dbo].[SP_Personnel_GetByID]
	@id int
AS
SELECT s.Nom,s.NumBCE,s.AdresseId, p.Nom, Prenom, DateDeNaissance, DateDEngagement,Fonction,[Login], p.AdresseID, a.AdRue,a.AdNum, a.AdCp, a.AdVille, a.AdPays, a.NumTel, a.Email,p.AdresseID, b.AdRue,b.AdNum, b.AdCp, b.AdVille, b.AdPays, b.NumTel, b.Email

FROM Personnel p
INNER JOIN Adresse a
ON p.AdresseId = a.Id
INNER JOIN Showroom s
ON p.ShowroomId = s.Id
INNER JOIN Adresse b
ON s.AdresseId = b.Id
WHERE p.Id=@id
RETURN 0
