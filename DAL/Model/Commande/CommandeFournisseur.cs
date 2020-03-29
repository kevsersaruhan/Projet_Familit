using DAL.Model.Commande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Commande
{
  public class CommandeFournisseur : CommandeClient
  {

    public int FournisseurID { get; set; }
  }
}
