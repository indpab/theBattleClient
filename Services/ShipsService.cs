using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Exceptions;
using TheBattleShipClient.Models.Ships;

namespace TheBattleShipClient.Services
{
    public class ShipsService
    {
        public static string BASE_URL = Resources.ApiEndpoint+"Ships/";

        public static async Task<ShipResponse> Create(string token, string roomId, ShipRequest ship)
        {
            var jsonRequest = JsonConvert.SerializeObject(ship);
            HttpContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            Uri uri = new Uri(BASE_URL + roomId);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.PostAsync(uri, content);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<ShipResponse>(jsonResponse);
                }
                throw new ApiException(JsonConvert.DeserializeObject<ErrorResponse>(jsonResponse));
            }
        }

        
        public static async Task<ShipResponse> Update(string token, int shipId, ShipRequest ship)
        {
            var jsonRequest = JsonConvert.SerializeObject(ship);
            HttpContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            Uri uri = new Uri(BASE_URL + shipId);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.PutAsync(uri, content);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<ShipResponse>(jsonResponse);
                }
                throw new ApiException(JsonConvert.DeserializeObject<ErrorResponse>(jsonResponse));
            }
        }

        

        public class ShipRequest
        {
            public int X { get; set; }
            public int XOffset { get; set; }
            public int Y { get; set; }
            public int YOffset { get; set; }
            public int ShipTypeId { get; set; }
        }
        public class ShipResponse
        {
            public int Id { get; set; }
            public int X { get; set; }
            public int XOffset { get; set; }
            public int Y { get; set; }
            public int YOffset { get; set; }
            public double HP { get; set; }
        }
        public class ShipGroupResponse
        {
            public ShipTypeResponse ShipType { get; set; }
            public int Count { get; set; }
            public int Limit { get; set; }
            public IEnumerable<ShipResponse> Ships { get; set; }
        }
        public class ShipTypeResponse
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Size { get; set; }
            public bool IsSubmarine { get; set; }
        }
    }
}
