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
    Helper h = new Helper();
    public CommandeClient Add(CommandeClient entity)
    {
      return h.PostAsyncObject(entity, "Secure/CommandeClient");
    }

    public void Delete(int id, CommandeClient entity)
    {
      h.DeleteAsync(id, entity, "Secure/CommandeClient/" + id);
    }

    public IEnumerable<CommandeClient> Get()
    {
      return h.GetAsyncList<CommandeClient>("CommandeClient");
    }

    public CommandeClient Get(int id)
    {
      return h.GetAsync<CommandeClient>("CommandeClient/" + id);
    }

    public bool Update(int id, CommandeClient entity)
    {
      return h.PutBool(id, entity, "Secure/CommandeClient/" + id);
    }

    public CommandeClient UpdateAndGet(int id, CommandeClient entity)
    {
      if (this.Update(id, entity)) return this.Get(id);
      return entity;
    }
    public IEnumerable<CommandeClient> GetCommandeClient(int idclient)
    {
      return h.GetAsyncList<CommandeClient>("CommandeClient/" + idclient + "/GetCommandeClient");
    }
  }
}
