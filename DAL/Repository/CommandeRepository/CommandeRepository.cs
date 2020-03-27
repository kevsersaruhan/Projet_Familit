using DAL.Model.Commande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.CommandeRepository
{
  public class CommandeRepository : IRepository<int, Commandes>
  {
    public void Add(Commandes entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Commandes> Get()
    {
      throw new NotImplementedException();
    }

    public Commandes Get(int id)
    {
      throw new NotImplementedException();
    }

    public void Update(int id)
    {
      throw new NotImplementedException();
    }
  }
}
