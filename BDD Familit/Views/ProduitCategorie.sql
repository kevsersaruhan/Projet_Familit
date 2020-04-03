CREATE VIEW [dbo].[ProduitCategorie]
	AS SELECT
  p.Id AS ProductID,
  p.Nom AS Nom,
  p.IsActif AS IsActif,
  p.Prix,
  p.PrixDAchatHTVA,
  p.TVA,
  p.Details,
  p.CategorieId,
  p.ClientId,
  p.NbPiece,
  cat.Nom AS CatNom,
  cat.IsActif AS CatIsActif,
  cat.Details AS CatDetails,
  cat.Id AS CatID,
  c.ClientID as FournisseurID,
  c.Nom AS FournisseurNom,
  c.Prenom,
  c.Login,
  c.IsActif AS ClientIsActif,
  c.AdresseId,
  c.NumBCE,
  c.AdRue,
  c.AdNum,
  c.AdCp,
  c.AdVille,
  c.AdPays,
  c.NumTel,
  c.EMail
  FROM Product p
  INNER JOIN ClientAdresse c
  ON c.ClientID = p.ClientId
  INNER JOIN Categories cat
  ON p.CategorieId = cat.Id
 
