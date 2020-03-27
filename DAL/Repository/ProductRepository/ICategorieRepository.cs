using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ProductRepository
{
  interface ICategorieRepository<TKey, T> : IRepository<TKey, T> where T : class
  {
    IEnumerable<T> GetCategorieByName(string s);
  }
}
