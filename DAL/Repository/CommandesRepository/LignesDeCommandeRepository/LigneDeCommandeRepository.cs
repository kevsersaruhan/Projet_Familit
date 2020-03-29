using DAL.Model.Commande;
using DAL.Repository.ProductsRepository;
using DAL.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.CommandesRepository.LignesDeCommandeRepository
{
  public class LigneDeCommandeRepository : IRepository<int, LigneDeCommande>
  {
    private string _constring = ConfigurationManager.ConnectionStrings["BDD_Familit"].ConnectionString;
    ProductRepository prodRepo = new ProductRepository();
    public void Add(LigneDeCommande entity)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_LignesDeCommande_Add";
          command.Parameters.AddWithValue("@Total", entity.TOTAL);
          command.Parameters.AddWithValue("@quantite", entity.Quantite);
          command.Parameters.AddWithValue("@HTVA", entity.HTVA);
          command.Parameters.AddWithValue("@TVAC", entity.TVAC);
          command.Parameters.AddWithValue("@ProductID", entity.Product.ID);
          command.Parameters.AddWithValue("@CommandeId", entity.IDCommande);
          command.Parameters.AddWithValue("@productName", entity.Product.Nom);
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
          command.CommandText = "SP_LignesDeCommande_Delete";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          command.ExecuteNonQuery();
        }
      }
    }

    public IEnumerable<LigneDeCommande> Get()
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_LignesDeCommande_GetAll";
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new LigneDeCommande()
              {
                ID = (int)reader["Id"],
                TOTAL=(double)reader["Total"],
                HTVA=(double)reader["HTVA"],
                TVAC=(double)reader["TVAC"],
                Quantite=(int)reader["Quantite"],
                IDCommande=(int)reader["CommandeId"],
                Product=prodRepo.Get((int)reader["ProductId"])
              };
            }
          }
        }
      }
    }

    public LigneDeCommande Get(int id)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_LignesDeCommande_GetByID";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              return new LigneDeCommande()
              {
                ID = (int)reader["Id"],
                TOTAL = (double)reader["Total"],
                HTVA = (double)reader["HTVA"],
                TVAC = (double)reader["TVAC"],
                Quantite = (int)reader["Quantite"],
                IDCommande = (int)reader["CommandeId"],
                Product = prodRepo.Get((int)reader["ProductId"])
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

    public IEnumerable<LigneDeCommande> GetByCommandeId(int idCommande)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_LignesDeCommande_GetByCommande";
          command.Parameters.AddWithValue("@idCommande", idCommande);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new LigneDeCommande()
              {
                ID = (int)reader["Id"],
                TOTAL = (double)reader["Total"],
                HTVA = (double)reader["HTVA"],
                TVAC = (double)reader["TVAC"],
                Quantite = (int)reader["Quantite"],
                IDCommande = (int)reader["CommandeId"],
                Product = prodRepo.Get((int)reader["ProductId"])
              };
            }
          }
        }
      }
    }
    public IEnumerable<LigneDeCommande> GetByProductId(int idProduct)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_LignesDeCommande_GetByProduct";
          command.Parameters.AddWithValue("@idProduct", idProduct);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new LigneDeCommande()
              {
                ID = (int)reader["Id"],
                TOTAL = (double)reader["Total"],
                HTVA = (double)reader["HTVA"],
                TVAC = (double)reader["TVAC"],
                Quantite = (int)reader["Quantite"],
                IDCommande = (int)reader["CommandeId"],
                Product = prodRepo.Get((int)reader["ProductId"])
              };
            }
          }
        }
      }
    }
    public void Update(int id, LigneDeCommande entity)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_LignesDeCommande_Update";
          command.Parameters.AddWithValue("@Total", entity.TOTAL);
          command.Parameters.AddWithValue("@quantite", entity.Quantite);
          command.Parameters.AddWithValue("@HTVA", entity.HTVA);
          command.Parameters.AddWithValue("@TVAC", entity.TVAC);
          command.Parameters.AddWithValue("@ProductID", entity.Product.ID);
          command.Parameters.AddWithValue("@CommandeId", entity.IDCommande);
          command.Parameters.AddWithValue("@productName", entity.Product.Nom);
          connection.Open();
          command.ExecuteNonQuery();
        }
      }
    }
  }
}
