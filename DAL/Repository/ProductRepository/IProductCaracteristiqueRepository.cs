
using DAL.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ProductRepository
{
    public interface IProductCaracteristiqueRepository<TKey, T> : IRepository<TKey,T> where T:class
    {
      void AddCaracteristiqueToProduct(int idCaract, int idProduct);
      void DeleteCaracteristiqueFromProduct(int idCaract);

       IEnumerable<CaracteristiqueProduct> GetByProduct(int idProduct);
      IEnumerable<CaracteristiqueProduct> GetByCaracteristique(int idCaracteristique);
    }
}
