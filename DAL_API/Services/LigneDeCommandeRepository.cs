using DAL_API.Modele.Commandes;
using DAL_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class LigneDeCommandeRepository : IRepository<int, LigneDeCommande>
  {
    Helper h = new Helper();
    public LigneDeCommande Add(LigneDeCommande entity)
    {
      return h.PostAsyncObject(entity, "Secure/LigneDeCommande");
    }

    public void Delete(int id, LigneDeCommande entity)
    {
      h.DeleteAsync(id, entity, "Secure/LigneDeCommande/" + id);
    }

    public IEnumerable<LigneDeCommande> Get()
    {
      return h.GetAsyncList<LigneDeCommande>("LigneDeCommande");
    }

    public LigneDeCommande Get(int id)
    {
      return h.GetAsync<LigneDeCommande>("LigneDeCommande/" + id);
    }
    public bool Update(int id, LigneDeCommande entity)
    {
      return h.PutBool(id, entity, "Secure/LigneDeCommande/" + id);
    }

    public LigneDeCommande UpdateAndGet(int id, LigneDeCommande entity)
    {
      if (this.Update(id, entity)) return this.Get(id);
      return entity;
    }
  }
}
