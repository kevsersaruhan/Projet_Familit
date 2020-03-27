using DAL.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ProductRepository
{
  public interface IProductRepository<TKey, T> : IRepository<TKey, T> where T: class
  {
    IEnumerable<T> GetProductByName(string s);
    IEnumerable<T> GetProductByFournisseur(int id);

  }
}
