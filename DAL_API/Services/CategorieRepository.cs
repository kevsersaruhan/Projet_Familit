using DAL_API.Modele.Produits;
using DAL_API.Repository.ProduitRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class CategorieRepository : ICategorieRepository<int, Categorie>
  {
    Helper h = new Helper();
    public bool Activer(int id, Categorie entity)
    {
      return h.PutBool(id, entity, "Secure/Categorie/" + id + "/Activer");
    }

    public Categorie Add(Categorie entity)
    {
      return h.PostAsyncObject(entity, "Secure/Categorie");
    }

    public void Delete(int id, Categorie entity)
    {
      h.DeleteAsync(id, entity, "Secure/Categorie/" + id);
    }

    public bool Desactiver(int id, Categorie entity)
    {
      return h.PutBool(id, entity, "Secure/Categorie/" + id + "/Desactiver");

    }

    public IEnumerable<Categorie> Get()
    {
      return h.GetAsyncList<Categorie>("Categorie");
    }

    public Categorie Get(int id)
    {
      return h.GetAsync<Categorie>("Categorie/" + id);
    }

    public IEnumerable<Categorie> GetCategorieByName(string s)
    {
      return h.GetAsyncList<Categorie>("Categorie / " + s + " / GetByName");
    }
    public bool Update(int id, Categorie entity)
    {
      return h.PutBool(id, entity, "Secure/Categorie/" + id);
    }
    public Categorie UpdateAndGet(int id, Categorie entity)
    {
      if (this.Update(id, entity)) return this.Get(id);
      return entity;
    }
  }
}
