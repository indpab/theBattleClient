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
    public class RoomsService
    {
        public const string BASE_URL = "https://thebattleshipapi.azurewebsites.net/api/v1/Rooms/";

        public static async Task<RoomResponse> Create(string token, RoomRequest request)
        {
            var jsonRequest = JsonConvert.SerializeObject(request);
            HttpContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            Uri uri = new Uri(BASE_URL);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.PostAsync(uri, content);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<RoomResponse>(jsonResponse);
                }
                throw new ApiException(JsonConvert.DeserializeObject<ErrorResponse>(jsonResponse));
            }
        }
        
        public static async Task<RoomResponse> Join(string token, string roomId)
        {
            var jsonRequest = JsonConvert.SerializeObject(new RoomRequest());
            HttpContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            Uri uri = new Uri(BASE_URL + roomId);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.PutAsync(uri, content);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<RoomResponse>(jsonResponse);
                }
                throw new ApiException(JsonConvert.DeserializeObject<ErrorResponse>(jsonResponse));
            }
        }

        /*
        public Task<bool> IsMyTurn(string token)
        {

        }
        */

       public static async Task<bool> CheckGuest(string token, string roomId)
       {
            Uri uri = new Uri(BASE_URL + roomId);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync(uri);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<RoomGetResponse>(jsonResponse).IsGuestUserJoinedIn;
                }
                throw new ApiException(JsonConvert.DeserializeObject<ErrorResponse>(jsonResponse));
            }

        }

        public class RoomRequest
        {
            public int Size { get; set; }
        }
        public class RoomResponse
        {
            public string Id { get; set; }
            public int Size { get; set; }
        }

        public class RoomGetResponse
        {
            public bool IsGuestUserJoinedIn { get; set; }
        }
    }
}
