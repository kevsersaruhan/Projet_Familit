CREATE VIEW [dbo].[PersonnelShowroom]
AS
SELECT
p.Id as personnelID,
p.IsActif,
p.Nom,
Prenom,
DateDeNaissance,
DateDEngagement,
Fonction,
[Login],
p.AdresseID as PersonnelAdresseID,
a.AdRue as PersonnelAdRue,
a.AdNum as PersonnelAdNum,
a.AdCp as PersonnelAdCp,
a.AdVille as PersonnelAdVille,
a.AdPays as PersonnelAdPays,
a.NumTel as PersonnelNumTel,
a.Email as PersonnelEmail,
s.Id as ShowroomID,
s.Nom as ShowroomName ,
s.NumBCE as ShowroomNumBCE,
s.AdresseId as ShowroomAdresseID,
s.IsActif as ShowroomIsActif,
b.AdRue,
b.AdNum,
b.AdCp,
b.AdVille,
b.AdPays,
b.NumTel,
b.Email

FROM Personnel p
INNER JOIN Adresse a
ON p.AdresseId = a.Id
INNER JOIN Showroom s
ON p.ShowroomId = s.Id
INNER JOIN Adresse b
ON s.AdresseId = b.Id

