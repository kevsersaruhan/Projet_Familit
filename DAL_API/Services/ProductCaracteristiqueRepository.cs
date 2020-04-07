using DAL_API.Repository.ProduitRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class ProductCaracteristiqueRepository : IProductCaracteristiqueRepository
  {
    Helper h = new Helper();
    public bool AddCaracteristiqueToProduct(int idCaract, int idProduct)
    {
      return h.PutBool("Secure/CaracteristiqueProduct/" + idCaract + "/" + idProduct + "/Add");
    }

    public void DeleteCaracteristiqueFromProduct(int idCaract, int idProduct)
    {
      h.DeleteAsync("Secure/CaracteristiqueProduct/" + idCaract + "/" + idProduct + "/Delete");
    }
  }
}
