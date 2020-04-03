using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Modele.Commandes
{
  public class CommandeClient
  {
    public int VendeurID { get; set; }
    public string MoyenDePaiement { get; set; }
    public string Statut { get; set; }
    public bool? Livraison { get; set; }
    public DateTime? DateDeLivraison { get; set; }
  }
}
