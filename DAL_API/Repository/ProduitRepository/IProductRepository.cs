using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Repository.ProduitRepository
{
  public interface IProductRepository<TKey, T> : IRepository<TKey, T> where T : class
  {
    IEnumerable<T> GetProductByName(string s);
    IEnumerable<T> GetProductByFournisseur(int id);
    IEnumerable<T> GetProductFav(int id);
    IEnumerable<T> GetProductListByCaracteristique(int idcaract);
    bool Desactiver(TKey id, T entity);
    bool Activer(TKey id, T entity);
  }
}
