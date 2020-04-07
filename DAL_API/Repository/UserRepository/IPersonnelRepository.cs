using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Repository.UserRepository
{
  public interface IPersonnelRepository<TKey, T> : IRepository<TKey, T> where T : class
  {
    bool  ChangePassword(TKey id, string s, T entity);
    void CheckPersonnel(TKey id, string login, string password,T entity);
    bool DoAdmin(TKey id, T entity);
    bool UnsetAdmin(TKey id, T entity);
    IEnumerable<T> GetPersonnelByShowroom(int idShowroom);
    bool Desactiver(TKey id, T entity);
    bool Activer(TKey id,T entity);
  }
}
