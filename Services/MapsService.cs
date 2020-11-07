using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Exceptions;
using TheBattleShipClient.Models;
using static TheBattleShipClient.Services.ShipsService;
using static TheBattleShipClient.Services.WeaponsService;

namespace TheBattleShipClient.Services
{
    public class MapsService
    {
        public const string BASE_URL = "https://thebattleshipapi.azurewebsites.net/api/v1/Maps/";
        public static async Task<MapResponse> GetMap(string token, string roomId)
        {
            Uri uri = new Uri(BASE_URL  + roomId);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync(uri);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<MapResponse>(jsonResponse);
                }
                throw new ApiException(JsonConvert.DeserializeObject<ErrorResponse>(jsonResponse));
            }

        }

        public static async Task<bool> IsMyTurn(string token, string roomId)
       {
            Uri uri = new Uri(BASE_URL + "CanDoAction/" + roomId);
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
            public int? EnemyShot_X { get; set; }
            public int? EnemyShot_Y { get; set; }

        }
        public class MapResponse
        {
            public bool IsCompleted { get; set; }
            public int? EnemyShot_X { get; set; }
            public int? EnemyShot_Y { get; set; }
            public IEnumerable<ShipGroupResponse> ShipGroups { get; set; }
            public IEnumerable<WeaponResponse> Weapons { get; set; }
        }


    }
}
