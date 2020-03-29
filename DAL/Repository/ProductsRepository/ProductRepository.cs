using DAL.Model.Product;
using DAL.Repository.UserRepository;
using DAL.Utils.ProductUtils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.ProductsRepository
{
  public class ProductRepository : IProductRepository<int,Products>
  {
    private string _constring = ConfigurationManager.ConnectionStrings["BDD_Familit"].ConnectionString;
    CategorieRepository CateRepo = new CategorieRepository();
    ClientRepository ClientRepo = new ClientRepository();
    CaracteristiqueRepository CaractRepo = new CaracteristiqueRepository();

    public void Add(Products entity)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Product_Add";
          command.Parameters.AddWithValue("@nom", entity.Nom);
          command.Parameters.AddWithValue("@Prix", entity.Prix);
          command.Parameters.AddWithValue("@prixDAchatHTVA", entity.PrixDAchatTHTVA);
          command.Parameters.AddWithValue("@TVA", entity.TVA);
          command.Parameters.AddWithValue("@nbPiece", entity.NbPiece);
          command.Parameters.AddWithValue("@details", entity.Details);
          command.Parameters.AddWithValue("@catId", entity.CatId);
          command.Parameters.AddWithValue("@clientId", entity.ClientId);
          connection.Open();
          entity.ID = (int)command.ExecuteScalar();
        }
      }
    }

    public void Delete(int id)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Product_Delete";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          command.ExecuteNonQuery();
        }
      }
    }

    public IEnumerable<Products> Get()
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Product_GetAll";
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new Products() {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Prix = (double)reader["Prix"],
                PrixDAchatTHTVA = (double)reader["PrixDAchatHTVA"],
                TVA = (double)reader["TVA"],
                NbPiece = (int)reader["NbPiece"],
                Details = (string)reader["Details"],
                CatId =(int)reader["CategorieId"],
                ClientId=(int)reader["ClientId"],
                Fournisseur = ClientRepo.GetClientById((int)reader["ClientId"]),
                Categorie = CateRepo.Get((int)reader["CategorieId"]),
                ListeCaracteristiques=CaractRepo.GetCaracteristiqueByProduct((int)reader["Id"])};
            }
          }
        }
      }
    }

    public Products Get(int id)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Product_GetById";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              return new Products()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Prix = (double)reader["Prix"],
                PrixDAchatTHTVA = (double)reader["PrixDAchatHTVA"],
                TVA = (double)reader["TVA"],
                NbPiece = (int)reader["NbPiece"],
                Details = (string)reader["Details"],
                CatId = (int)reader["CategorieId"],
                ClientId = (int)reader["ClientId"],
                Fournisseur = ClientRepo.GetClientById((int)reader["ClientId"]),
                Categorie = CateRepo.Get((int)reader["CategorieId"]),
                ListeCaracteristiques = CaractRepo.GetCaracteristiqueByProduct((int)reader["Id"])
              };
            }
            else
            {
              return null;
            }
          }
        }
      }
    }

    public IEnumerable<Products> GetProductByFournisseur(int id)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Product_GetByfournisseur";
          command.Parameters.AddWithValue("@clientId", id);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new Products()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Prix = (double)reader["Prix"],
                PrixDAchatTHTVA = (double)reader["PrixDAchatHTVA"],
                TVA = (double)reader["TVA"],
                NbPiece = (int)reader["NbPiece"],
                Details = (string)reader["Details"],
                CatId = (int)reader["CategorieId"],
                ClientId = (int)reader["ClientId"],
                Fournisseur = ClientRepo.GetClientById((int)reader["ClientId"]),
                Categorie = CateRepo.Get((int)reader["CategorieId"]),
                ListeCaracteristiques = CaractRepo.GetCaracteristiqueByProduct((int)reader["Id"])
              };
            }
          }
        }
      }
    }

    public IEnumerable<Products> GetProductByName(string s)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Product_GetByName";
          command.Parameters.AddWithValue("@nom", s);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new Products()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Prix = (double)reader["Prix"],
                PrixDAchatTHTVA = (double)reader["PrixDAchatHTVA"],
                TVA = (double)reader["TVA"],
                NbPiece = (int)reader["NbPiece"],
                Details = (string)reader["Details"],
                CatId = (int)reader["CategorieId"],
                ClientId = (int)reader["ClientId"],
                Fournisseur = ClientRepo.GetClientById((int)reader["ClientId"]),
                Categorie = CateRepo.Get((int)reader["CategorieId"]),
                ListeCaracteristiques = CaractRepo.GetCaracteristiqueByProduct((int)reader["Id"])
              };
            }
          }
        }
      }
    }

    public IEnumerable<Products> GetProductFav(int idclient)
    {
      List<Products> ListeProduitsFav = new List<Products>();
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Client_Product_Fav";
          command.Parameters.AddWithValue("@id", idclient);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              Products p = new Products();
              p = Get((int)reader["ProductId"]);
              ListeProduitsFav.Add(p);
            }
            return ListeProduitsFav;
          }
        }
      }
    }

    public IEnumerable<Products> GetProductListByCaracteristique(int idcaract)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          List<Products> ListeProduit = new List<Products>();
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Product_Caracteristique_GetByCaracteristique";
          command.Parameters.AddWithValue("@idcaract", idcaract);
          connection.Open();
          using(SqlDataReader reader = command.ExecuteReader())
          { 
             while (reader.Read())
             {
                Products p = new Products();
                p = Get((int)reader["ProductId"]);
                ListeProduit.Add(p);
             }
          }
          return ListeProduit;
        }
      }
    }

    public void Update(int id, Products entity)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Product_Update";
          command.Parameters.AddWithValue("@nom", entity.Nom);
          command.Parameters.AddWithValue("@prixDAchatHTVA", entity.PrixDAchatTHTVA);
          command.Parameters.AddWithValue("@prix", entity.Prix);
          command.Parameters.AddWithValue("@TVA", entity.TVA);
          command.Parameters.AddWithValue("@nbPiece", entity.NbPiece);
          command.Parameters.AddWithValue("@details", entity.Details);
          command.Parameters.AddWithValue("@catId", entity.CatId);
          command.Parameters.AddWithValue("@clientId", entity.ClientId);
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          command.ExecuteNonQuery();

        }
      }
    }
  }
}
