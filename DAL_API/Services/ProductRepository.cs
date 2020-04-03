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
    public void Activer(int id)
    {
      throw new NotImplementedException();
    }

    public void Add(Produit entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public void Desactiver(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Produit> Get()
    {
      throw new NotImplementedException();
    }

    public Produit Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Produit> GetProductByFournisseur(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Produit> GetProductByName(string s)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Produit> GetProductFav(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Produit> GetProductListByCaracteristique(int idcaract)
    {
      throw new NotImplementedException();
    }

    public void Update(int id, Produit entity)
    {
      throw new NotImplementedException();
    }
  }
}
