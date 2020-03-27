using DAL.Model.Commande;
using DAL.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.User
{
 public class Client : User
  {
    public Client()
    {
      ListFav = new List<Products>();
      ListCommande = new List<CommandeClients>();
    }
    public List<Products> ListFav { get; set; }
    public List<CommandeClients> ListCommande { get; set; }
  }
}
