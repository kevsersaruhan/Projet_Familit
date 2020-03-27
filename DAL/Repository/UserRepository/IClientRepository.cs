using DAL.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.UserRepository
{
  public interface IClientRepository<TKey,T> : IRepository<TKey, T> where T : class
  {
    void ChangePassword(TKey id, string password);
    void CheckClient(TKey id, string login, string password);
    IEnumerable<T> GetByName(string name);

  }
}
