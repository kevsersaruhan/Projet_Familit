using DAL_API.Modele.Users;
using DAL_API.Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class ClientRepository : IClientRepository<int, Client>
  {
    public void Activer(int id)
    {
      throw new NotImplementedException();
    }

    public void Add(Client entity)
    {
      throw new NotImplementedException();
    }

    public void ChangePassword(int id, string password)
    {
      throw new NotImplementedException();
    }

    public void CheckClient(int id, string login, string password)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public void Desactiver(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Client> Get()
    {
      throw new NotImplementedException();
    }

    public Client Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Client> GetByName(string name)
    {
      throw new NotImplementedException();
    }

    public void Update(int id, Client entity)
    {
      throw new NotImplementedException();
    }
  }
}
