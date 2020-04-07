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
    Helper h = new Helper();
    public bool Activer(int id, Client entity)
    {
      return h.PutBool(id, entity, "Secure/Client/" + id + "/Activer");
    }

    public Client Add(Client entity)
    {
      return h.PostAsyncObject(entity, "Secure/Client");
    }

    public bool ChangePassword(int id, string password, Client entity)
    {
      return h.PutBool("Secure/Client/" + id + "/ChangePassword/" + password);
    }

    public bool CheckClient(int id, string login, string password,Client entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id, Client entity)
    {
      h.DeleteAsync(id, entity, "Secure/Client/" + id);
    }

    public bool Desactiver(int id, Client entity)
    {
      return h.PutBool(id, entity, "Secure/Client/" + id + "/Desactiver");
    }

    public IEnumerable<Client> Get()
    {
      return h.GetAsyncList<Client>("Client");
    }

    public Client Get(int id)
    {
      return h.GetAsync<Client>("Client/" + id);
    }
    public IEnumerable<Client> GetByName(string name)
    {
      return h.GetAsyncList<Client>("Client / " + name + " / GetByName");
    }

    public bool Update(int id, Client entity)
    {
      return h.PutBool(id, entity, "Secure/Client/" + id);
    }

    public Client UpdateAndGet(int id, Client entity)
    {
      if (this.Update(id, entity)) return this.Get(id);
      return entity;
    }
    public bool AddProductToFav(int idProduct, int idClient)
    {
      return h.PutBool("Secure/ClientProduct/" + idClient + "/" + idProduct + "/Add");
    }
    public void DeleteProductFav(int id)
    {
      h.DeleteAsync("Secure/ClientProduct/" + id + "/Delete");
    }
  }
}
