using DAL_API.Modele.Commandes;
using DAL_API.Modele.Produits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Modele.Users
{
  class Client
  {
    public Client()
    {
      ListFav = new List<Produit>();
      ListCommande = new List<CommandeClient>();
    }
    public string NumBCE { get; set; }
    public bool EstFournisseur { get; set; }
    public IEnumerable<Produit> ListFav { get; set; }
    public IEnumerable<CommandeClient> ListCommande { get; set; }
  }
}
