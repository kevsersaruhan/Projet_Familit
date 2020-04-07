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
    public Helper h = new Helper();
    public Commande Add(Commande entity)
    {
      return h.PostAsyncObject(entity, "Secure/Commande");
    }

    public void Delete(int id, Commande entity)
    {
      h.DeleteAsync(id, entity, "Secure/Commande/" + id);
    }

    public IEnumerable<Commande> Get()
    {
      return h.GetAsyncList<Commande>("Commande");
    }

    public Commande Get(int id)
    {
      return h.GetAsync<Commande>("Commande/" + id);
    }
    public bool Update(int id, Commande entity)
    {
      return h.PutBool(id, entity, "Secure/Commande/" + id);
    }
    public Commande UpdateAndGet(int id, Commande entity)
    {
      if (this.Update(id, entity)) return this.Get(id);
      return entity;
    }
  }
}
