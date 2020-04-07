using DAL_API.Modele.Users;
using DAL_API.Repository.UserRepository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class PersonnelRepository : IPersonnelRepository<int, Personnel>
  {
    public Helper h = new Helper();
    public bool Activer(int id, Personnel entity)
    {
      return h.PutBool(id, entity, "Secure/Personnel/"+id+"/Activer");
    }

    public Personnel Add(Personnel entity)
    {
      return h.PostAsyncObject(entity, "Secure/Personnel");
    }

    public bool ChangePassword(int id, string s, Personnel entity)
    {
      return h.PutBool("Secure/Personnel/"+id+"/ChangePassword/"+s);
    }

    //pas encore implémenté
    public void CheckPersonnel(int id, string login, string password, Personnel entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id, Personnel entity)
    {
      h.DeleteAsync(id, entity, "Secure/Personnel/" + id);
    }

    public bool Desactiver(int id, Personnel entity)
    {
      return h.PutBool(id, entity, "Secure/Personnel/" + id + "/Desactiver");
    }

    public bool DoAdmin(int id, Personnel entity)
    {
      return h.PutBool(id, entity, "Secure/Personnel/" + id + "/DoAdmin");
    }

    public IEnumerable<Personnel> Get()
    {
      return h.GetAsyncList<Personnel>("Personnel");
    }

    public Personnel Get(int id)
    {
      return h.GetAsync<Personnel>("Personnel/" + id);
    }

    public IEnumerable<Personnel> GetPersonnelByShowroom(int idShowroom)
    {
      return h.GetAsyncList<Personnel>("Personnel/"+idShowroom+"/GetByShowroom");
    }

    public bool UnsetAdmin(int id, Personnel entity)
    {
      return h.PutBool(id, entity, "Secure/Personnel/" + id + "/UnsetAdmin");
    }

    public bool Update(int id, Personnel entity)
    {
      return h.PutBool(id, entity, "Secure/Personnel/" + id);
    }

    public Personnel UpdateAndGet(int id, Personnel entity)
    {
      if (this.Update(id, entity)) return this.Get(id);
      return entity;
    }
  }
}
