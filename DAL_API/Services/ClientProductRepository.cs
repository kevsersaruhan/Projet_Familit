using DAL_API.Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class ClientProductRepository : IClientProductFavRepository
  {
    public void AddProductToFav(int idProduct, int idClient)
    {
      throw new NotImplementedException();
    }

    public void DeleteProductFav(int id)
    {
      throw new NotImplementedException();
    }
  }
}
