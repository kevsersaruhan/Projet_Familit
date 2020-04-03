using DAL_API.Modele.Commandes;
using DAL_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class CommandeClientRepository : IRepository<int, CommandeClient>
  {
    public void Add(CommandeClient entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<CommandeClient> Get()
    {
      throw new NotImplementedException();
    }

    public CommandeClient Get(int id)
    {
      throw new NotImplementedException();
    }

    public void Update(int id, CommandeClient entity)
    {
      throw new NotImplementedException();
    }
    public IEnumerable<CommandeClient> GetCommandeClient(int idclient)
    {
      throw new NotImplementedException();
    }
  }
}
