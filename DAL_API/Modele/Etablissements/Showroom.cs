using DAL_API.Modele.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Modele.Etablissements
{
  public class Showroom
  {
    public Showroom()
    {
      PersonnelList = new List<Personnel>();
    }
    public int ID { get; set; }
    public string Nom { get; set; }
    public string NumBCE { get; set; }
    public string AdRue { get; set; }
    public string AdNum { get; set; }
    public int AdCP { get; set; }
    public string AdVille { get; set; }
    public string AdPays { get; set; }
    public int NumTel { get; set; }
    public string Email { get; set; }
    public IEnumerable<Personnel> PersonnelList { get; set; }
    public bool IsActif { get; set; }
  }
}
