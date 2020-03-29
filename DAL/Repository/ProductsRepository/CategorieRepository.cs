using DAL.Model.Product;
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
  public class CategorieRepository : ICategorieRepository<int, Categories>
  {
    private string _constring = ConfigurationManager.ConnectionStrings["BDD_Familit"].ConnectionString;
    CaracteristiqueRepository caracRepo = new CaracteristiqueRepository();
    public void Add(Categories entity)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Categorie_Add";
          command.Parameters.AddWithValue("@Nom", entity.Nom);
          command.Parameters.AddWithValue("@Details", entity.Details);
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
          command.CommandText = "SP_Categorie_Delete";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          command.ExecuteNonQuery();
        }
      }
    }

    public IEnumerable<Categories> Get()
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Categorie_GetAll";
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new Categories()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Details = (string)reader["Details"],
                ListeCaracteristique = caracRepo.GetCaracteristiqueByCategorie((int)reader["Id"])
              };
            }
          }
        }
      }
    }

    public Categories Get(int id)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Categorie_GetById";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              return new Categories()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Details = (string)reader["Details"],
                ListeCaracteristique = caracRepo.GetCaracteristiqueByCategorie((int)reader["Id"])
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

    public IEnumerable<Categories> GetCategorieByName(string s)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Categorie_GetByName";
          command.Parameters.AddWithValue("@nom", s);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new Categories()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Details = (string)reader["Details"],
                ListeCaracteristique = caracRepo.GetCaracteristiqueByCategorie((int)reader["Id"])
              };
            }
          }
        }
      }
    }

    public void Update(int id, Categories entity)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Caracteristique_Update";
          command.Parameters.AddWithValue("@nom", entity.Nom);
          command.Parameters.AddWithValue("@details", entity.Details);
          connection.Open();
          command.ExecuteNonQuery();
        }
      }
    }
  }
  }

