using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AppLibrary
{
  public record Generic(int A, int B, int C);
  public class Fetching
  {
    public static async Task<(List<Generic>, string)> GetDataFromHttp()
    {
      var client = new HttpClient();
      var jsonTask = client.GetFromJsonAsync<List<Generic>>("https://raw.githubusercontent.com/chyld/datasets/main/generic.json");
      var csvTask = client.GetStringAsync("https://raw.githubusercontent.com/chyld/datasets/main/auto-mpg.csv");
      await Task.WhenAll(jsonTask, csvTask);

      if (jsonTask.Status != TaskStatus.RanToCompletion) throw new Exception("JSON Error");
      if (csvTask.Status != TaskStatus.RanToCompletion) throw new Exception("CSV Error");

      return (jsonTask.Result, csvTask.Result);
    }
  }
}
