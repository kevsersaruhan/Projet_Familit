using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Product
{
  public class Caracteristique
  {
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Details { get; set; }
    public Categories Categorie { get; set; }
    public IEnumerable<Products> ListeProduits { get; set; }
    private int _CatId;

    public int CatId
    {
      get { return _CatId; }
      set { _CatId = Categorie.ID; }
    }

  }
}
