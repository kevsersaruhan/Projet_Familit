using DAL_API.Modele.Etablissements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Modele.Users
{
  public class Personnel : User
  {
    public DateTime DateDeNaissance { get; set; }
    public string Fonction { get; set; }
    public bool IsAdmin { get; set; }
    public DateTime HireDate { get; set; }
    public int NbJoursAbsence { get; set; }
    public int NbJourVacance { get; set; }
    public double Salaire { get; set; }
    public Showroom LieuDeTravail { get; set; }
    public int ShowroomId { get; set; }
  }
}
