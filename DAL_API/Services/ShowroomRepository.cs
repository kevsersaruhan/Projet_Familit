using DAL_API.Modele.Etablissements;
using DAL_API.Repository.EtablissementRepository;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DAL_API.Services
{
  public class ShowroomRepository : IShowroomRepository<int, Showroom>
  {
    public Showroom Activer(int id, Showroom entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity); HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.PutAsync("Secure/Showroom/"+id+"/Activer", httpContent).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Showroom>(json);
      }
    }

    public Showroom Add(Showroom entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity);
        HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.PostAsync("Secure/Showroom",httpContent).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Showroom>(json);
      }
    }

    public void Delete(int id, Showroom entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity);
        HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.DeleteAsync("Secure/Showroom/" + id).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
      }
    }

    public Showroom Desactiver(int id, Showroom entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity);
        HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.PutAsync("Secure/Showroom/"+id+"/Desactiver", httpContent).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Showroom>(json);
      }
    }

    public IEnumerable<Showroom> Get()
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        HttpResponseMessage httpResponseMessage = httpclient.GetAsync("Showroom").Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Showroom[]>(json);
      }
    }

    public Showroom Get(int id)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        HttpResponseMessage httpResponseMessage = httpclient.GetAsync("Showroom/"+id).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Showroom>(json);
      }
    }

    public IEnumerable<Showroom> GetShowroomByName(string name)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        HttpResponseMessage httpResponseMessage = httpclient.GetAsync("Showroom/"+name+"/GetByName").Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Showroom[]>(json);
      }
    }

    public Showroom Update(int id, Showroom entity)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        string jsonContent = JsonConvert.SerializeObject(entity);
        HttpContent httpContent = new StringContent(jsonContent);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.PutAsync("Secure/Showroom/"+id, httpContent).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //parseur de json va retransformer en objet
        return JsonConvert.DeserializeObject<Showroom>(json);
      }
    }
  }
}
