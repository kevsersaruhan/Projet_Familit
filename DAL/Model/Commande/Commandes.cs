using DAL.Model.Commande
  ;
using DAL.Model.Etablissement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Commande
{
  public abstract class Commandes
  {
    public Commandes()
    {
      DetailsCommande = new List<LigneDeCommande>();
    }

    public int ID { get; set; }
    public IEnumerable<LigneDeCommande> DetailsCommande { get; set; }
    public DateTime DateDeCommande { get; set; }
    public bool? Livraison { get; set; }
    public DateTime? DateDeLivraison { get; set; }
    public double Total { get; set; }
    public double Acompte { get; set; }
    public double Solde { get; set; }
    public Showrooms Showroom { get; set; }
    public string TypeDeCommande { get; set; }
  }
}
