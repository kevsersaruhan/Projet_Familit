using DAL_API.Modele.Users;
using DAL_API.Repository.UserRepository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class PersonnelRepository : IPersonnelRepository<int, Personnel>
  {
    public Personnel Activer(int id, Personnel entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity); HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.PutAsync("Secure/Personnel/" + id + "/Activer", httpContent).Result;

        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Personnel>(json);
      }
    }

    public Personnel Add(Personnel entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity);
        HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.PostAsync("Secure/Personnel", httpContent).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Personnel>(json);
      }
    }

    public Personnel ChangePassword(int id, string s, Personnel entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity);
        HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.PutAsync("Secure/Personnel/"+id+"/ChangePassword/"+s, httpContent).Result;

        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Personnel>(json);
      }
    }

    public void CheckPersonnel(int id, string login, string password, Personnel entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity);
        HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.DeleteAsync("Secure/Personnel/{id}/{login}/{password}").Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
      }
    }

    public void Delete(int id, Personnel entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity);
        HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.DeleteAsync("Secure/Personnel/"+id).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
      }
    }

    public Personnel Desactiver(int id, Personnel entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity);
        HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.PutAsync("Secure/Personnel/" + id + "/Desactiver", httpContent).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Personnel>(json);
      }
    }

    public Personnel DoAdmin(int id, Personnel entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity); HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.PutAsync("Secure/Personnel/" + id + "/DoAdmin", httpContent).Result;

        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Personnel>(json);
      }
    }

    public IEnumerable<Personnel> Get()
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        HttpResponseMessage httpResponseMessage = httpclient.GetAsync("Personnel").Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Personnel[]>(json);
      }
    }

    public Personnel Get(int id)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        HttpResponseMessage httpResponseMessage = httpclient.GetAsync("Personnel/"+id).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Personnel>(json);
      }
    }

    public IEnumerable<Personnel> GetPersonnelByShowroom(int idShowroom)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        HttpResponseMessage httpResponseMessage = httpclient.GetAsync("Personnel/"+idShowroom"/).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Personnel[]>(json);
      }
    }

    public Personnel UnsetAdmin(int id, Personnel entity)
    {
      throw new NotImplementedException();
    }

    public Personnel Update(int id, Personnel entity)
    {
      throw new NotImplementedException();
    }
  }
}
