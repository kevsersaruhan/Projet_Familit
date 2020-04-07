using DAL_API.Modele.Produits;
using DAL_API.Repository.ProduitRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class CaracteristiqueRepository : ICaracteristiqueRepository<int, Caracteristique>
  {
    Helper h = new Helper();
    public Caracteristique Add(Caracteristique entity)
    {
      return h.PostAsyncObject(entity, "Secure/Caracteristique");
    }

    public void Delete(int id, Caracteristique entity)
    {
      h.DeleteAsync(id, entity, "Secure/Caracteristique/" + id);
    }

      public IEnumerable<Caracteristique> Get()
    {
      return h.GetAsyncList<Caracteristique>("Showroom");
    }

    public Caracteristique Get(int id)
    {
      return h.GetAsync<Caracteristique>("Caracteristique/" + id);
    }

    public IEnumerable<Caracteristique> GetCaracteristiqueByCategorie(int idcat)
    {
      return h.GetAsyncList<Caracteristique>("Caracteristique/" + idcat + "/GetByCategorie");

    }

    public IEnumerable<Caracteristique> GetCaracteristiqueByProduct(int idproduct)
    {
      return h.GetAsyncList<Caracteristique>("Caracteristique/" + idproduct+ "/GetByProduct");

    }
    public bool Update(int id, Caracteristique entity)
    {
      return h.PutBool(id, entity, "Secure/Caracteristique/" + id);
    }
    public Caracteristique UpdateAndGet(int id, Caracteristique entity)
    {
      if (this.Update(id, entity)) return this.Get(id);
      return entity;
    }
  }
}
