using DAL_API.Modele.Etablissements;
using DAL_API.Repository.EtablissementRepository;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using DAL_API.Repository;

namespace DAL_API.Services
{
  public class ShowroomRepository : IShowroomRepository<int, Showroom>
  {
    Helper h = new Helper();
    public bool Activer(int id, Showroom entity)
    {
      return h.PutBool(id, entity, "Secure/Showroom/" + id + "/Activer");
    }

    public Showroom Add(Showroom entity)
    {
      return h.PostAsyncObject(entity, "Secure/Showroom");
    }

    public void Delete(int id, Showroom entity)
    {
      h.DeleteAsync(id, entity, "Secure/Showroom/" + id);
    }

    public bool Desactiver(int id, Showroom entity)
    {
      return h.PutBool(id, entity, "Secure/Showroom/" + id + "/Desactiver");
    }

    public IEnumerable<Showroom> Get()
    {
      return h.GetAsyncList<Showroom>("Showroom");
    }

    public Showroom Get(int id)
    {
      return h.GetAsync<Showroom>("Showroom/" + id+"/GetById");
    }

    public IEnumerable<Showroom> GetShowroomByName(string name)
    {
      return h.GetAsyncList<Showroom>("Showroom / " + name + " / GetByName");
    }

    public bool Update(int id, Showroom entity)
    {
      return h.PutBool(id, entity, "Secure/Showroom/" + id);
    }

    public Showroom UpdateAndGet(int id, Showroom entity)
    {
      if (this.Update(id, entity)) return this.Get(id);
      return entity;
    }
  }
}
