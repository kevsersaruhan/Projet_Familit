using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Repository.ProduitRepository
{
  public interface ICaracteristiqueRepository<TKey, T> : IRepository<TKey, T> where T : class
  {
    IEnumerable<T> GetCaracteristiqueByCategorie(int idcat);
    IEnumerable<T> GetCaracteristiqueByProduct(int idproduct);
  }
}
