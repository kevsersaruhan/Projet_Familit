CREATE VIEW [dbo].[ShowroomAdresse]
AS
SELECT s.Id as ShowroomId, Nom, NumBCE,IsActif, AdresseId, AdRue,AdNum, AdCp, AdVille, AdPays, NumTel, Email
FROM Showroom s
JOIN Adresse a
ON s.AdresseId = a.Id
