using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Repository.ProduitRepository
{
  public interface IProductCaracteristiqueRepository
  {
    bool AddCaracteristiqueToProduct(int idCaract, int idProduct);
    void DeleteCaracteristiqueFromProduct(int idCaract, int idProduct);
  }
}
