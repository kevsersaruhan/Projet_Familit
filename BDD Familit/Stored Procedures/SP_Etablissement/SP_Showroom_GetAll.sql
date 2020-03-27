CREATE PROCEDURE [dbo].[SP_Showroom_GetAll]
AS
SELECT Nom, NumBCE, AdresseID, AdRue,AdNum, AdCp, AdVille, AdPays, NumTel, Email
FROM Showroom s
JOIN Adresse a
ON s.AdresseId = a.Id
