using DAL_API.Modele.Produits;
using DAL_API.Repository.ProduitRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class ProductRepository : IProductRepository<int, Produit>
  {
    public Helper h = new Helper();
    public bool Activer(int id, Produit entity)
    {
      return h.PutBool(id, entity, "Secure/Product/" + id + "/Activer");
    }

    public Produit Add(Produit entity)
    {
      return h.PostAsyncObject(entity, "Secure/Product");
    }

    public void Delete(int id, Produit entity)
    {
      h.DeleteAsync(id, entity, "Secure/Product/" + id);
    }

    public bool Desactiver(int id, Produit entity)
    {
      return h.PutBool(id, entity, "Secure/Product/" + id + "/Desactiver");
    }

    public IEnumerable<Produit> Get()
    {
      return h.GetAsyncList<Produit>("Product");
    }

    public Produit Get(int id)
    {
      return h.GetAsync<Produit>("Product/" + id);
    }

    public IEnumerable<Produit> GetProductByFournisseur(int id)
    {
      return h.GetAsyncList<Produit>("Product/"+id+"/GetByFournisseur");
    }

    public IEnumerable<Produit> GetProductByName(string s)
    {
      return h.GetAsyncList<Produit>("Product/" + s + "/GetByName");
    }

    public IEnumerable<Produit> GetProductFav(int id)
    {
      return h.GetAsyncList<Produit>("Product/" + id + "/GetProductFav");
    }

    public IEnumerable<Produit> GetProductListByCaracteristique(int idcaract)
    {
      return h.GetAsyncList<Produit>("Product/" + idcaract + "/GetByCaracteristique");

    }

    public bool Update(int id, Produit entity)
    {
      return h.PutBool(id, entity, "Secure/Product/" + id);
    }

    public Produit UpdateAndGet(int id, Produit entity)
    {
      if (this.Update(id, entity)) return this.Get(id);
      return entity;
    }
  }
}
