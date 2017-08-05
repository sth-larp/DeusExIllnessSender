using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DeusExIllnessSender
{
  class Program
  {
    static void Main() => MainAsync().GetAwaiter().GetResult();

    static async Task MainAsync()
    {
      await Task.WhenAll((await GetAliceStatAsync()).Select(id => SendEventsToAlice(new RollIlness(id.ToString()))));
      //await SendEventsToAlice(new StartIlness("10762", "Diabetes"));
      //await SendEventsToAlice(new StartIlness("10762", "CoronaryHeartDisease"));
      //await SendEventsToAlice(new StartIlness("10762", "SystemicLupusErythematosus"));
      //await SendStartIllness();
      Console.ReadLine();
    }

    private static async Task SendStartIllness()
    {
      await Task.WhenAll(new[]
      {
        SendEventsToAlice(new StartIlness("14466", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("4382", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("15468", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("4376", "coronaryheartdisease ")),
        SendEventsToAlice(new StartIlness("11705", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("4390", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("11416", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("11707", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("15529", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("14573", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("11656", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("15356", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("11706", "CoronaryHeartDisease")),
        
        SendEventsToAlice(new StartIlness("11713", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("12282", "CoronaryHeartDisease")),
        SendEventsToAlice(new StartIlness("14270", "SystemicLupusErythematosus")),
        SendEventsToAlice(new StartIlness("13578", "SystemicLupusErythematosus")),
        SendEventsToAlice(new StartIlness("4376", "SystemicLupusErythematosus")),
        SendEventsToAlice(new StartIlness("14569", "SystemicLupusErythematosus")),
        SendEventsToAlice(new StartIlness("14569", "SystemicLupusErythematosus")),
        SendEventsToAlice(new StartIlness("12267", "SystemicLupusErythematosus")),
        SendEventsToAlice(new StartIlness("11980", "SystemicLupusErythematosus")),
        SendEventsToAlice(new StartIlness("13358", "SystemicLupusErythematosus")),
        SendEventsToAlice(new StartIlness("14574", "SystemicLupusErythematosus")),
        SendEventsToAlice(new StartIlness("13576", "Diabetes")),
        SendEventsToAlice(new StartIlness("4376", "Diabetes")),
        SendEventsToAlice(new StartIlness("12291", "Diabetes")),
        SendEventsToAlice(new StartIlness("11695", "Diabetes")),
        SendEventsToAlice(new StartIlness("14562", "Diabetes")),
        SendEventsToAlice(new StartIlness("14257", "Diabetes")),
        SendEventsToAlice(new StartIlness("12285", "Diabetes")),
        SendEventsToAlice(new StartIlness("12286", "Diabetes")),
        SendEventsToAlice(new StartIlness("4379", "Diabetes")),
        SendEventsToAlice(new StartIlness("12284", "Diabetes")),
        SendEventsToAlice(new StartIlness("13961", "Pleurisy")),
        SendEventsToAlice(new StartIlness("14571", "Pleurisy")),
        SendEventsToAlice(new StartIlness("15053", "Pleurisy")),
        SendEventsToAlice(new StartIlness("11708", "Pleurisy")),
        SendEventsToAlice(new StartIlness("4376", "Pleurisy")),
        SendEventsToAlice(new StartIlness("11701", "Pleurisy")),
        SendEventsToAlice(new StartIlness("13049", "Pleurisy")),
        SendEventsToAlice(new StartIlness("13221", "Pleurisy")),
        SendEventsToAlice(new StartIlness("12291", "Pleurisy")),
        SendEventsToAlice(new StartIlness("14256", "Pleurisy")),
        SendEventsToAlice(new StartIlness("11697", "Pleurisy")),
        SendEventsToAlice(new StartIlness("12285", "Pleurisy")),
        SendEventsToAlice(new StartIlness("15537", "Pleurisy")),
        SendEventsToAlice(new StartIlness("13091", "Pleurisy")),
        SendEventsToAlice(new StartIlness("11710", "Pleurisy")),
        SendEventsToAlice(new StartIlness("4372", "Pleurisy")),
        SendEventsToAlice(new StartIlness("12287", "Pleurisy")),
        SendEventsToAlice(new StartIlness("11703", "Pleurisy")),
        SendEventsToAlice(new StartIlness("11863", "Pleurisy")),
        SendEventsToAlice(new StartIlness("14572", "AnkylosingSpondylitis")),
        SendEventsToAlice(new StartIlness("11708", "AnkylosingSpondylitis")),
        SendEventsToAlice(new StartIlness("6402", "AnkylosingSpondylitis")),
        SendEventsToAlice(new StartIlness("7023", "AnkylosingSpondylitis")),
        SendEventsToAlice(new StartIlness("12289", "AnkylosingSpondylitis")),
        SendEventsToAlice(new StartIlness("13221", "AnkylosingSpondylitis")),
        SendEventsToAlice(new StartIlness("12285", "AnkylosingSpondylitis")),
        SendEventsToAlice(new StartIlness("12283", "AnkylosingSpondylitis")),
        SendEventsToAlice(new StartIlness("15510", "AnkylosingSpondylitis")),
        SendEventsToAlice(new StartIlness("11706", "AnkylosingSpondylitis")),
        SendEventsToAlice(new StartIlness("15493", "AnkylosingSpondylitis")),
        SendEventsToAlice(new StartIlness("11641", "Dementia")),
        SendEventsToAlice(new StartIlness("4338", "Dementia")),
        SendEventsToAlice(new StartIlness("15868", "Dementia")),
        SendEventsToAlice(new StartIlness("13577", "Dementia")),
        SendEventsToAlice(new StartIlness("12288", "Dementia")),
        SendEventsToAlice(new StartIlness("4376", "Dementia")),
        SendEventsToAlice(new StartIlness("13574", "Dementia")),
        SendEventsToAlice(new StartIlness("11712", "Dementia")),
        SendEventsToAlice(new StartIlness("11695", "Dementia")),
        SendEventsToAlice(new StartIlness("12293", "Dementia")),
        SendEventsToAlice(new StartIlness("7415", "Dementia")),
        SendEventsToAlice(new StartIlness("4386", "Dementia")),
      });
    }

    public static async Task SendEventsToAlice(CharacterEvent @event)
    {
      var url = "https://alice.digital:6984" + "/events";

      
      var client = new HttpClient();

      var body = MyJsonSerializer.SerializeToJsonString(@event);

      var request = new HttpRequestMessage(HttpMethod.Post, url);
      request.Content = new StringContent(body, Encoding.UTF8, "application/json");
      request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
      request.Headers.Authorization = new AuthenticationHeaderValue("Basic", "ZWNvbm9taWNzOno2dHJFKnJVRHJ1OA==");

      var millisecondsDelay =  60 * 1000 / 15000 * (int.Parse(@event.characterId) - 4000);
      Console.WriteLine($"Sending to {@event.characterId} with delay {millisecondsDelay}");
      
      await Task.Delay(millisecondsDelay);
      var response = await client.SendAsync(request);
      var responseBody = await response.Content.ReadAsStringAsync();

      if (!response.IsSuccessStatusCode)
      {
        Console.WriteLine(response.ToString());
      }
      else
      {
        Console.WriteLine($"Send correct to {@event.characterId}");
      }
    }

    public static async Task<List<int>> GetAliceStatAsync()
    {

      var models = await GetAliceData();

      return models.Where(x => x.isAlive && x.inGame).Select(x => int.Parse(x._id)).ToList();

    }

    public static async Task<List<AliceModel>> GetAliceData()
    {
      var url = "https://alice.digital:6984" + "/models/_all_docs";

      var webClient = new WebClient();
      webClient.QueryString.Add("include_docs", "true");
      webClient.Headers.Add("Authorization", "Basic ZWNvbm9taWNzOno2dHJFKnJVRHJ1OA==");
      webClient.Headers.Add("Accept", "application/json");
      webClient.Headers.Add("Content-type", "application/json");
      string result = await webClient.DownloadStringTaskAsync(url);

      var models = JsonConvert.DeserializeObject < AliceModels>(result);
      var characters = models.rows.Select(x => x.doc).ToList();
      return characters;
    }
  }

  
}