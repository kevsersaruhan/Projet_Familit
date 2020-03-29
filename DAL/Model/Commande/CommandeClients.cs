using DAL.Model.Commande;
using DAL.Model.Etablissement;
using DAL.Model.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Commande
{
  public class CommandeClients : Commandes
  {
    public int ClientID { get; set; }
    public int VendeurID { get; set; }
    public string MoyenDePaiement { get; set; }
    public string Statut { get; set; }

  }
}
