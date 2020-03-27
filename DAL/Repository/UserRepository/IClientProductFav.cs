using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.UserRepository
{
  public interface IClientProductFav
  {
    void AddProductToFav(int idProduct, int idClient);
    void DeleteProductFav(int id);
  }
}
