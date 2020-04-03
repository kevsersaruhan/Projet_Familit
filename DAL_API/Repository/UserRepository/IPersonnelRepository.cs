using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Repository.UserRepository
{
  public interface IPersonnelRepository<TKey, T> : IRepository<TKey, T> where T : class
  {
    T  ChangePassword(TKey id, string s, T entity);
    void CheckPersonnel(TKey id, string login, string password,T entity);
    T DoAdmin(TKey id, T entity);
    T UnsetAdmin(TKey id, T entity);
    IEnumerable<T> GetPersonnelByShowroom(int idShowroom);
    T Desactiver(TKey id, T entity);
    T Activer(TKey id,T entity);
  }
}
