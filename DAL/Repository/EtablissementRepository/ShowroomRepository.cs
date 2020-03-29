using DAL.Model.Etablissement;
using DAL.Repository.UserRepository;
using DAL.Utils.EtablissementUtils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.EtablissementRepository
{
  public class ShowroomRepository : IShowroomRepository<int, Showrooms>
  {
    private string _constring = ConfigurationManager.ConnectionStrings["BDD_Familit"].ConnectionString;
    PersonnelRepository persoRepo = new PersonnelRepository();
    public void Add(Showrooms entity)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Showroom_Add";
          command.Parameters.AddWithValue("@nom", entity.Nom);
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

    public void Delete(int id)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Showroom_Delete";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          command.ExecuteNonQuery();
        }
      }
    }

    public IEnumerable<Showrooms> Get()
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Showroom_GetAll";
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new Showrooms()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                NumBCE = (string)reader["NumBCE"],
                AdRue = (string)reader["AdRue"],
                AdNum = (string)reader["AdNum"],
                AdCP = (int)reader["AdCp"],
                AdVille = (string)reader["AdVille"],
                AdPays = (string)reader["AdPays"],
                NumTel = (int)reader["NumTel"],
                Email = (string)reader["EMail"],
                PersonnelList = persoRepo.GetPersonnelByShowroom((int)reader["Id"])
              };
            }
          }
        }
      }
    }

    public Showrooms Get(int id)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Showroom_GetByID";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            if (reader.Read())
            {
              return new Showrooms()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                NumBCE = (string)reader["NumBCE"],
                AdRue = (string)reader["AdRue"],
                AdNum = (string)reader["AdNum"],
                AdCP = (int)reader["AdCp"],
                AdVille = (string)reader["AdVille"],
                AdPays = (string)reader["AdPays"],
                NumTel = (int)reader["NumTel"],
                Email = (string)reader["EMail"],
                PersonnelList = persoRepo.GetPersonnelByShowroom(id)
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

    public IEnumerable<Showrooms> GetShowroomByName(string name)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Showroom_GetByName";
          command.Parameters.AddWithValue("@nom", name);
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new Showrooms()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                NumBCE = (string)reader["NumBCE"],
                AdRue = (string)reader["AdRue"],
                AdNum = (string)reader["AdNum"],
                AdCP = (int)reader["AdCp"],
                AdVille = (string)reader["AdVille"],
                AdPays = (string)reader["AdPays"],
                NumTel = (int)reader["NumTel"],
                Email = (string)reader["EMail"],
                PersonnelList = persoRepo.GetPersonnelByShowroom((int)reader["Id"])
              };
            }
          }
        }
      }
    }

    public void Update(int id, Showrooms entity)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Showroom_Update";
          command.Parameters.AddWithValue("@nom", entity.Nom);
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
