using DAL_API.Modele.Produits;
using DAL_API.Repository.ProduitRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class CaracteristiqueRepository : ICaracteristiqueRepository<int, Caracteristique>
  {
    public void Add(Caracteristique entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Caracteristique> Get()
    {
      throw new NotImplementedException();
    }

    public Caracteristique Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Caracteristique> GetCaracteristiqueByCategorie(int idcat)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Caracteristique> GetCaracteristiqueByProduct(int idproduct)
    {
      throw new NotImplementedException();
    }

    public void Update(int id, Caracteristique entity)
    {
      throw new NotImplementedException();
    }
  }
}
