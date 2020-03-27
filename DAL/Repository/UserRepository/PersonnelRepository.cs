using DAL.Model.Repertoire;
using DAL.Model.User;
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
  public class PersonnelRepository : IPersonnelRepository<int, Personnel>
  {
    private string _constring = ConfigurationManager.ConnectionStrings["BDD_Familit"].ConnectionString;
    public void Add(Personnel entity)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Personnel_Add";
          command.Parameters.AddWithValue("@nom", entity.Nom);
          command.Parameters.AddWithValue("@Prenom", entity.Prenom);
          command.Parameters.AddWithValue("@dateDeNaissance", entity.DateDeNaissance);
          command.Parameters.AddWithValue("@Login", entity.Login);
          command.Parameters.AddWithValue("@Password", entity.Password);
          command.Parameters.AddWithValue("@Function", entity.Fonction);
          command.Parameters.AddWithValue("@IsAdmin", entity.IsAdmin);
          command.Parameters.AddWithValue("@DateDengagement", entity.HireDate);
          command.Parameters.AddWithValue("@NbJourAbsence", entity.NbJoursAbsence);
          command.Parameters.AddWithValue("@NbJourVacances", entity.NbJourVacance);
          command.Parameters.AddWithValue("@ShowroomId", entity.ShowroomId);
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

    public void ChangePassword(int id, string s)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Personnel_ChangePassword";
          command.Parameters.AddWithValue("@id", id);
          command.Parameters.AddWithValue("@password", s);
          connection.Open();
          command.ExecuteNonQuery();

        }
      }
    }

    public void CheckPersonnel(int id, string login, string password)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Personnel_Check";
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
          command.CommandText = "SP_Personnel_Delete";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          command.ExecuteNonQuery();
        }
      }
    }

    public void DoAdmin(int id)
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_Personnel_DoAdmin";
          command.Parameters.AddWithValue("@id", id);
          connection.Open();
          command.ExecuteNonQuery();
        }
      }
    }

    public IEnumerable<Personnel> Get()
    {
      using (SqlConnection connection = new SqlConnection(_constring))
      {
        using (SqlCommand command = connection.CreateCommand())
        {
          command.CommandType = CommandType.StoredProcedure;
          command.CommandText = "SP_GetAll";
          connection.Open();
          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              yield return new Personnel()
              {
                ID = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Prenom = (string)reader["Prenom"],
                DateDeNaissance = (DateTime)reader["DateDeNaissance"],
                HireDate =(DateTime)reader["DateDengagement"],
                Fonction =(string)reader["Fonction"],
                Login=(string)reader["Login"],
                Password = "********",
                NbJoursAbsence=(int)reader["NbJourAbsence"],
                NbJourVacance=(int)reader["NbJourVacances"],
               
              };
            }
          }
        }
      }
    }
    //p.Nom, Prenom, DateDeNaissance, DateDEngagement,Fonction,[Login], p.AdresseID, a.AdRue,a.AdNum, a.AdCp, a.AdVille,
    //  a.AdPays, a.NumTel, a.Email,p.AdresseID, b.AdRue,b.AdNum, b.AdCp, b.AdVille, b.AdPays, b.NumTel, b.Email

    public Personnel Get(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Personnel> GetByName(string name)
    {
      throw new NotImplementedException();
    }

    public void UnsetAdmin(int id)
    {
      throw new NotImplementedException();
    }

    public void Update(int id)
    {
      throw new NotImplementedException();
    }
  }
}
