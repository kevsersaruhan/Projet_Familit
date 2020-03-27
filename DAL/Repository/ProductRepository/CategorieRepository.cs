using DAL.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ProductRepository
{
  public class CategorieRepository : ICategorieRepository<int, Categories>
  {
    public void Add(Categories entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Categories> Get()
    {
      throw new NotImplementedException();
    }

    public Categories Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Categories> GetCategorieByName(string s)
    {
      throw new NotImplementedException();
    }

    public void Update(int id)
    {
      throw new NotImplementedException();
    }
  }
}
