using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Repository.EtablissementRepository
{
  public interface IShowroomRepository<Tkey, T> : IRepository<Tkey, T> where T : class
  {
    IEnumerable<T> GetShowroomByName(string name);
    T Desactiver(Tkey id, T entity);
    T Activer(Tkey id, T entity);
  }
}
