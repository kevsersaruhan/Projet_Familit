using DAL.Model.Commande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.CommandeRepository.LigneDeCommandeRepository
{
  public class LigneDeCommandeRepository : IRepository<int, LigneDeCommande>
  {
    public void Add(LigneDeCommande entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<LigneDeCommande> Get()
    {
      throw new NotImplementedException();
    }

    public LigneDeCommande Get(int id)
    {
      throw new NotImplementedException();
    }

    public void Update(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<LigneDeCommande> GetByCommandeId(int idCommande)
    {
      throw new NotImplementedException();
    }
    public IEnumerable<LigneDeCommande> GetByProductId(int idProduct)
    {
      throw new NotImplementedException();
    }

  }
}
