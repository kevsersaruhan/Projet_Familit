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
  public class Helper
  {
    public bool PutBool(string path)
    {
        using (HttpClient httpclient = new HttpClient())
        {
          httpclient.BaseAddress = new Uri("https://localhost:56503/");
          httpclient.DefaultRequestHeaders.Accept.Clear();
          httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          HttpContent httpContent = new StringContent(null);
          httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
          HttpResponseMessage httpResponseMessage = httpclient.PutAsync(path, httpContent).Result;
          return (int)(httpResponseMessage.EnsureSuccessStatusCode().StatusCode) >= 200 && (int)(httpResponseMessage.EnsureSuccessStatusCode().StatusCode) < 300; //si code 200 requete valide
        }
      
    }
      public bool PutBool<T>(int id, T entity, string path) where T : class
      {
        using (HttpClient httpclient = new HttpClient())
        {
          httpclient.BaseAddress = new Uri("https://localhost:56503/");
          httpclient.DefaultRequestHeaders.Accept.Clear();
          httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          string jsonContent = JsonConvert.SerializeObject(entity);
          HttpContent httpContent = new StringContent(jsonContent);
          httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
          HttpResponseMessage httpResponseMessage = httpclient.PutAsync(path, httpContent).Result;
          return (int)(httpResponseMessage.EnsureSuccessStatusCode().StatusCode) >= 200 && (int)(httpResponseMessage.EnsureSuccessStatusCode().StatusCode) < 300; //si code 200 requete valide
        }
      }
      public T PutObject<T>(int id, T entity, string path)
      {
        using (HttpClient httpclient = new HttpClient())
        {
          httpclient.BaseAddress = new Uri("https://localhost:56503/");
          httpclient.DefaultRequestHeaders.Accept.Clear();
          httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          string jsonContent = JsonConvert.SerializeObject(entity);
          HttpContent httpContent = new StringContent(jsonContent);
          httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
          HttpResponseMessage httpResponseMessage = httpclient.PutAsync(path, httpContent).Result;
          httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
          string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
          //parseur de json va retransformer en objet
          return JsonConvert.DeserializeObject<T>(json);
        }
      }
      public IEnumerable<T> GetAsyncList<T>(string path)
      {
        using (HttpClient httpclient = new HttpClient())
        {
          httpclient.BaseAddress = new Uri("https://localhost:56503/");
          httpclient.DefaultRequestHeaders.Accept.Clear();
          httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
          HttpResponseMessage httpResponseMessage = httpclient.GetAsync(path).Result;
          httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
          string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
          //parseur de json va retransformer en objet
          return JsonConvert.DeserializeObject<T[]>(json);
        }
      }
      public T GetAsync<T>(string path)
      {
        using (HttpClient httpclient = new HttpClient())
        {
          httpclient.BaseAddress = new Uri("https://localhost:56503/");
          httpclient.DefaultRequestHeaders.Accept.Clear();
          httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
          HttpResponseMessage httpResponseMessage = httpclient.GetAsync(path).Result;
          httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
          string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
          //parseur de json va retransformer en objet
          return JsonConvert.DeserializeObject<T>(json);
        }
      }
      public void DeleteAsync<T>(int id, T entity, string path)
      {
        using (HttpClient httpclient = new HttpClient())
        {
          httpclient.BaseAddress = new Uri("https://localhost:56503/");
          httpclient.DefaultRequestHeaders.Accept.Clear();
          httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          string jsonContent = JsonConvert.SerializeObject(entity);
          HttpContent httpContent = new StringContent(jsonContent);
          httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
          HttpResponseMessage httpResponseMessage = httpclient.DeleteAsync(path).Result;
          httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
        }
      }
    public void DeleteAsync(string path)
    {
      using (HttpClient httpclient = new HttpClient())
      {
        httpclient.BaseAddress = new Uri("https://localhost:56503/");
        httpclient.DefaultRequestHeaders.Accept.Clear();
        httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        HttpContent httpContent = new StringContent(null);
        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        HttpResponseMessage httpResponseMessage = httpclient.DeleteAsync(path).Result;
        httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
      }
    }
    public T PostAsyncObject<T>(T entity, string path)
      {
        using (HttpClient httpclient = new HttpClient())
        {
          httpclient.BaseAddress = new Uri("https://localhost:56503/");
          httpclient.DefaultRequestHeaders.Accept.Clear();
          httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

          string jsonContent = JsonConvert.SerializeObject(entity);
          HttpContent httpContent = new StringContent(jsonContent);
          httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
          HttpResponseMessage httpResponseMessage = httpclient.PostAsync(path, httpContent).Result;
          httpResponseMessage.EnsureSuccessStatusCode(); //si code 200 requete valide
          string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
          //parseur de json va retransformer en objet
          return JsonConvert.DeserializeObject<T>(json);
        }
      }
    
  }
}
