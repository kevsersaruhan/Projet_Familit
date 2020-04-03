using DAL_API.Modele.Commandes;
using DAL_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class CommandeRepository : IRepository<int, Commande>
  {
    public void Add(Commande entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Commande> Get()
    {
      throw new NotImplementedException();
    }

    public Commande Get(int id)
    {
      throw new NotImplementedException();
    }

    public void Update(int id, Commande entity)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Commande> GetCommandeClient(int idclient)
    {
      throw new NotImplementedException();
    }
  }
}
