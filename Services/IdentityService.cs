using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShipClient.Services
{
    public class IdentityService
    {
        public const string BASE_URL = "https://thebattleapi.azurewebsites.net/api/v1/Identity/";

        public static async Task<AuthenticationResponse> Register(UserRequest request)
        {
            var jsonRequest = JsonConvert.SerializeObject(request);
            HttpContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            Uri uri = new Uri(BASE_URL + "register");
            using(HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync(uri, content);
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<AuthenticationResponse>(responseString);
            }
        }

        public static async Task<AuthenticationResponse> Login(UserRequest request)
        {
            var jsonRequest = JsonConvert.SerializeObject(request);
            HttpContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            Uri uri = new Uri(BASE_URL + "login");
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync(uri, content);
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<AuthenticationResponse>(responseString);
            }
        }
    }

    public class AuthenticationResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }

    public class UserRequest
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
