using DAL.Model.Etablissement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.EtablissementRepository
{
  public class ShowroomRepository : IShowroomRepository<int, Showrooms>
  {
    public void Add(Showrooms entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Showrooms> Get()
    {
      throw new NotImplementedException();
    }

    public Showrooms Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Showrooms> GetShowroomByName(string name)
    {
      throw new NotImplementedException();
    }

    public void Update(int id)
    {
      throw new NotImplementedException();
    }
  }
}
