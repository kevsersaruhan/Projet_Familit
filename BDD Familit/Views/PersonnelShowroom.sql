CREATE VIEW [dbo].[PersonnelShowroom]
AS
SELECT
p.Id as personnelID,
p.IsActif,
p.IsAdmin,
p.Nom,
Prenom,
DateDeNaissance,
DateDEngagement,
NbJourAbsence,
NbJourVacances,
Fonction,
Salaire,
[Login],
p.AdresseId as PersoAdresseID,
a.AdRue as PersonnelAdRue,
a.AdNum as PersonnelAdNum,
a.AdCp as PersonnelAdCp,
a.AdVille as PersonnelAdVille,
a.AdPays as PersonnelAdPays,
a.NumTel as PersonnelNumTel,
a.EMail as PersoEmail,
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
b.EMail

FROM Personnel p
INNER JOIN Adresse a
ON p.AdresseId = a.Id
INNER JOIN Showroom s
ON p.ShowroomId = s.Id
INNER JOIN Adresse b
ON s.AdresseId = b.Id

