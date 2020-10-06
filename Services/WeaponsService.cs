using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Exceptions;
using TheBattleShipClient.Models.Weapons;

namespace TheBattleShipClient.Services
{
    public class WeaponsService
    {
        public const string BASE_URL = "https://thebattleshipapi.azurewebsites.net/api/v1/Weapons/";

        public static async Task<ShotResponse> Shot(string token, string roomId, WeaponRequest weapon)
        {
            var jsonRequest = JsonConvert.SerializeObject(weapon);
            HttpContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            Uri uri = new Uri(BASE_URL + roomId);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.PostAsync(uri, content);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<ShotResponse>(jsonResponse);
                }
                throw new ApiException(JsonConvert.DeserializeObject<ErrorResponse>(jsonResponse));
            }
        }

        /*
        public static async Task<string> UpdateWeapon(Weapon weapon)
        {

        }
        */

        public class WeaponRequest
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int WeaponTypeId { get; set; }
        }

        public class ShotResponse
        {
            public int WeaponId { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
            public bool Successful { get; set; }
            public IEnumerable<int> ShipTypes { get; set; }
        }
    }
}
