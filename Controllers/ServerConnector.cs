using TheBattleShipClient.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace TheBattleShipClient.Controllers
{
    public class ServerConnector : AbstractServerConnector
    {
        private static ServerConnector Connector;
        private static readonly object padlock = new object();

        private HttpClient Client = new HttpClient();
        //private readonly string BaseAddress = "https://thebattleapi.azurewebsites.net/api/";
        private readonly string BaseAddress = "https://localhost:44350/api/v1/";

        private readonly HttpMethod PatchMethod = new HttpMethod("PATCH");

        public static ServerConnector Instance
        { 
            get
            {
                if (Connector == null)
                {
                    lock (padlock)
                    {
                        if (Connector == null)
                        {
                            Connector = new ServerConnector();
                        }
                    }
                }
                return Connector;
            }
        }

        protected ServerConnector()
        {
            Client.BaseAddress = new Uri(BaseAddress);
        }

        public override void SetBaseAddress(string baseAddress)
        {
            Client.BaseAddress = new Uri(baseAddress);
        }

        public async override Task<string> GetAction(string requestUri)
        {
            HttpResponseMessage message = await Client.GetAsync(requestUri);
            return await message.Content.ReadAsStringAsync();
        }

        public async override Task<string> PostAction(string requestUri, string content)
        {
            HttpContent httpcontent = new StringContent(content, Encoding.UTF8, "application/json");

            HttpResponseMessage message = await Client.PostAsync(requestUri, httpcontent);

            return await message.Content.ReadAsStringAsync();
        }

        public async override void PutAction(string requestUri, string content)
        {
            HttpContent httpcontent = new StringContent(content, Encoding.UTF8, "application/json");

            await Client.PutAsync(requestUri, httpcontent);
        }

        public async override void PatchAction(string requestUri, string content)
        {
            HttpContent httpcontent = new StringContent(content, Encoding.UTF8, "application/json");

            await Client.SendAsync(new HttpRequestMessage(PatchMethod, requestUri) { Content = httpcontent });
        }

        public async override void DeleteAction(string requestUri)
        {
            await Client.DeleteAsync(requestUri);
        }
    }
}
