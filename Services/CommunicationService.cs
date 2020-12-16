using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Exceptions;
using TheBattleShipClient.Models.Communication;

namespace TheBattleShipClient.Services
{
    public class CommunicationService
    {
        public static string BASE_URL = Resources.ApiEndpoint + "Messages/";
        public static async Task<List<Message>> GetAllMessagesByRoomId(string token, string roomId)
        {
            Uri uri = new Uri(BASE_URL + "ByRoom/" + roomId);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync(uri);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<Message>>(jsonResponse);
                }
                throw new ApiException(JsonConvert.DeserializeObject<ErrorResponse>(jsonResponse));
            }

        }

        public static async Task<MessageResponse> PostMessage(string token, string roomId, string msg)
        {
            MessageRequest message = new MessageRequest
            {
                MessageContent = msg
            };
            var jsonRequest = JsonConvert.SerializeObject(message);
            HttpContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            Uri uri = new Uri(BASE_URL + "roomId?roomId=" + roomId);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.PostAsync(uri, content);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return new MessageResponse { Id = Convert.ToInt32(jsonResponse) };
                }
                return null;
            }
        }
        public class MessageResponse
        {
            public int Id { get; set; }

        }

        public class MessagesResponse
        {
            public List<Message> Messages { get; set; }
        }

        public class MessageRequest { 
            public string MessageContent { get; set; }
        }

    }
}
