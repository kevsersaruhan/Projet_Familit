using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Modele.Produits
{
  public class Caracteristique
  {
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Details { get; set; }
    public Categorie Categorie { get; set; }
    public IEnumerable<Produit> ListeProduits { get; set; }
    public int CatId { get; set; }
  }
}
