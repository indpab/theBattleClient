using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Exceptions;

namespace TheBattleShipClient.Services
{
    public class IdentityService
    {

        public static string BASE_URL = Resources.ApiEndpoint+"Identity/";

        public static async Task<AuthenticationResponse> Register(UserRequest request)
        {
            var jsonRequest = JsonConvert.SerializeObject(request);
            HttpContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            Uri uri = new Uri(BASE_URL + "register");
            using(HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync(uri, content);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<AuthenticationResponse>(responseString);
                }
                var errorResponse = JsonConvert.DeserializeObject<ErrorResponse.Root>(responseString);
               
                throw new ApiException(string.Join(',', errorResponse.Errors.Select((x) => x.Message)), new ErrorResponse());
                
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
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<AuthenticationResponse>(responseString);
                }
                var errorResponse = JsonConvert.DeserializeObject<ErrorResponse.Root>(responseString);

                throw new ApiException(string.Join(',', errorResponse.Errors.Select((x) => x.Message)), new ErrorResponse());

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
