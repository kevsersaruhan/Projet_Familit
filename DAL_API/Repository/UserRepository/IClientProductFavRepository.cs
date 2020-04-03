using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Repository.UserRepository
{
  public interface IClientProductFavRepository
  {
    void AddProductToFav(int idProduct, int idClient);
    void DeleteProductFav(int id);
  }
}
