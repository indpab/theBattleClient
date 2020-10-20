using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Exceptions;

namespace TheBattleShipClient.Services
{
    public class MapsService
    {
        public const string BASE_URL = "https://thebattleshipapi.azurewebsites.net/api/v1/Maps/";

        /*
        public Task<bool> IsMyTurn(string token)
        {

        }
        */

       public static async Task<bool> IsMyTurn(string token, string roomId)
       {
            Uri uri = new Uri(BASE_URL + "CanDoCation" + roomId);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync(uri);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<CanDoActionResponse>(jsonResponse).CanDoAction;
                }
                throw new ApiException(JsonConvert.DeserializeObject<ErrorResponse>(jsonResponse));
            }

        }

        public class CanDoActionResponse
        {
            public bool CanDoAction { get; set; }
            public int EnemyShot_X { get; set; }
            public int EnemyShot_Y { get; set; }

        }
    }
}
