using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Repository
{
  public interface IRepository<TKey, T> where T : class
  {
    IEnumerable<T> Get();
    T Get(TKey id);
    T Add(T entity);
    T Update(TKey id, T entity);
    void Delete(TKey id, T entity);

  }
}
