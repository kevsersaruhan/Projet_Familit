CREATE VIEW [dbo].[CaracteristiqueView]
	AS SELECT
  c.Id,
  c.Nom AS Nom,
  c.Details,
  c.CategorieId,
  cat.Nom AS CatNom,
  cat.Details AS CatDetails,
  cat.IsActif,
  cat.Id AS CatID
  FROM Caracteristique c
  INNER JOIN Categories cat
  ON c.CategorieId = cat.Id
