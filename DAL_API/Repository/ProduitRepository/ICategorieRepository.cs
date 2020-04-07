using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Repository.ProduitRepository
{
  public interface ICategorieRepository<TKey, T> : IRepository<TKey, T> where T : class
  {
    IEnumerable<T> GetCategorieByName(string s);
    bool Desactiver(TKey id, T entity);
    bool Activer(TKey id, T entity);
  }
}
