using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.EtablissementRepository
{
  public interface IShowroomRepository<Tkey,T> : IRepository<Tkey,T> where T:class
  {
    IEnumerable<T> GetShowroomByName(string name);
  }
}
