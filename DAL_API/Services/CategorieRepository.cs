using DAL_API.Modele.Produits;
using DAL_API.Repository.ProduitRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class CategorieRepository : ICategorieRepository<int, Categorie>
  {
    public void Activer(int id)
    {
      throw new NotImplementedException();
    }

    public void Add(Categorie entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public void Desactiver(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Categorie> Get()
    {
      throw new NotImplementedException();
    }

    public Categorie Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Categorie> GetCategorieByName(string s)
    {
      throw new NotImplementedException();
    }

    public void Update(int id, Categorie entity)
    {
      throw new NotImplementedException();
    }
  }
}
