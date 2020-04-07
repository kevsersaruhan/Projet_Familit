using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Repository.UserRepository
{
  public interface IClientRepository<TKey, T> : IRepository<TKey, T> where T : class
  {
    bool ChangePassword(TKey id, string password,T entity);
    bool CheckClient(TKey id, string login, string password, T entity);
    IEnumerable<T> GetByName(string name);
    bool Desactiver(TKey id, T entity);
    bool Activer(TKey id, T entity);
  }
}
