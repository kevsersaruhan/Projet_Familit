using DAL.Model.User;
using DAL.Repository.CommandesRepository;
using DAL.Repository.ProductsRepository;
using DAL.Utils.UserUtils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.UserRepository
{
  public class ClientRepository : IClientRepository<int, Client>
  {
    private string _constring = ConfigurationManager.ConnectionStrings["BDD_Familit"].ConnectionString;

    CommandeClientRepository commandeRepo = new CommandeClientRepository();
    ProductRepository productRepo = new ProductRepository();
    public void Add(Client entity)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Client_Add";
          command.Parameters.AddWithValue("@nom", entity.Nom);
          command.Parameters.AddWithValue("@Prenom", entity.Prenom);
          command.Parameters.AddWithValue("@Login", entity.Login);
          command.Parameters.AddWithValue("@Password", entity.Password);
          command.Parameters.AddWithValue("@EstFournisseur", entity.EstFournisseur);
          command.Parameters.AddWithValue("@NumBCE", entity.NumBCE);
          command.Parameters.AddWithValue("@adRue", entity.AdRue);
          command.Parameters.AddWithValue("@adNum", entity.AdNum);
          command.Parameters.AddWithValue("@adCp", entity.AdCP);
          command.Parameters.AddWithValue("@adVille", entity.AdVille);
          command.Parameters.AddWithValue("@adPays", entity.AdPays);
          command.Parameters.AddWithValue("@email", entity.Email);
          command.Parameters.AddWithValue("@numTel", entity.NumTel);
          connection.Open();
          entity.ID = (int)command.ExecuteScalar();
        }
      }
    }

    public void ChangePassword(int id, string password)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Client_ChangePassword";
          command.Parameters.AddWithValue("@id", id);
          command.Parameters.AddWithValue("@password", password);
          connection.Open();
          command.ExecuteNonQuery();

        }
      }
    }

    public void CheckClient(int id, string login, string password)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Client_Check";
          command.Parameters.AddWithValue("@login", login);
          command.Parameters.AddWithValue("@password", password);
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          command.ExecuteNonQuery();

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
          command.CommandText = "SP_Client_Delete";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          command.ExecuteNonQuery();
        }
      }
    }

    public IEnumerable<Client> Get()
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Client_GetAll";
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new Client()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Prenom = (string)reader["Prenom"],
                Login = (string)reader["Login"],
                Password = "********",
                NumBCE=(string)reader["NumBCE"],
                EstFournisseur=(bool)reader["EstFournisseur"],
                AdRue = (string)reader["AdRue"],
                AdNum = (string)reader["AdNum"],
                AdCP = (int)reader["AdCp"],
                AdVille = (string)reader["AdVille"],
                AdPays = (string)reader["AdPays"],
                NumTel = (int)reader["NumTel"],
                Email = (string)reader["EMail"]
              };
            }
          }
        }
      }
    }

    public Client Get(int id)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Client_GetByID";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              return new Client()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Prenom = (string)reader["Prenom"],
                Login = (string)reader["Login"],
                Password = "********",
                NumBCE = (string)reader["NumBCE"],
                EstFournisseur = (bool)reader["EstFournisseur"],
                AdRue = (string)reader["AdRue"],
                AdNum = (string)reader["AdNum"],
                AdCP = (int)reader["AdCp"],
                AdVille = (string)reader["AdVille"],
                AdPays = (string)reader["AdPays"],
                NumTel = (int)reader["NumTel"],
                Email = (string)reader["EMail"]
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

    public IEnumerable<Client> GetByName(string name)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Client_GetByName";
          command.Parameters.AddWithValue("@nom", name);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new Client()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Prenom = (string)reader["Prenom"],
                Login = (string)reader["Login"],
                Password = "********",
                NumBCE = (string)reader["NumBCE"],
                EstFournisseur = (bool)reader["EstFournisseur"],
                AdRue = (string)reader["AdRue"],
                AdNum = (string)reader["AdNum"],
                AdCP = (int)reader["AdCp"],
                AdVille = (string)reader["AdVille"],
                AdPays = (string)reader["AdPays"],
                NumTel = (int)reader["NumTel"],
                Email = (string)reader["EMail"],
                ListCommande = commandeRepo.GetCommandeClient((int)reader["Id"]),
                ListFav = productRepo.GetProductFav((int)reader["Id"])
            };
            }
          }
        }
      }
    }
    public void Update(int id, Client entity)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Client_Update";
          command.Parameters.AddWithValue("@nom", entity.Nom);
          command.Parameters.AddWithValue("@Prenom", entity.Prenom);
          command.Parameters.AddWithValue("@Login", entity.Login);
          command.Parameters.AddWithValue("@Password", entity.Password);
          command.Parameters.AddWithValue("@EstFournisseur", entity.EstFournisseur);
          command.Parameters.AddWithValue("@NumBCE", entity.NumBCE);
          command.Parameters.AddWithValue("@adRue", entity.AdRue);
          command.Parameters.AddWithValue("@adNum", entity.AdNum);
          command.Parameters.AddWithValue("@adCp", entity.AdCP);
          command.Parameters.AddWithValue("@adVille", entity.AdVille);
          command.Parameters.AddWithValue("@adPays", entity.AdPays);
          command.Parameters.AddWithValue("@email", entity.Email);
          command.Parameters.AddWithValue("@numTel", entity.NumTel);
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          command.ExecuteNonQuery();

        }
      }
    }
  }
}
