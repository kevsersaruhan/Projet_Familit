using DAL.Model.Product;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utils.ProductUtils
{
  interface ICategorieRepository<TKey, T> : IRepository<TKey, T> where T : class
  {
    IEnumerable<T> GetCategorieByName(string s);
  }
}
