using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
  public interface IRepository<TKey, T> where T :class
  {
    IEnumerable<T> Get();
    T Get(TKey id);
    void Add(T entity);
    void Update(TKey id);
    void Delete(TKey id);

  }
}
