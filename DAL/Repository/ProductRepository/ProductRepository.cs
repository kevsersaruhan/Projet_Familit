using DAL.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ProductRepository
{
  public class ProductRepository : IProductRepository<int, Products>
  {
    public void Add(Products entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Products> Get()
    {
      throw new NotImplementedException();
    }

    public Products Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Products> GetProductByFournisseur(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Products> GetProductByName(string s)
    {
      throw new NotImplementedException();
    }

    public void Update(int id)
    {
      throw new NotImplementedException();
    }
  }
}
