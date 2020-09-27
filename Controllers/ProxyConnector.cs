using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShipClient.Controllers
{
    class ProxyConnector : AbstractServerConnector
    {
        private ServerConnector Connector { get; set; }
        private static ProxyConnector Proxy;
        private static readonly object padlock = new object();
        protected ProxyConnector()
        {
            Connector = ServerConnector.Instance;
        }

        public static ProxyConnector Instance
        {
            get
            {
                if (Proxy == null)
                {
                    lock (padlock)
                    {
                        if (Proxy == null)
                        {
                            Proxy = new ProxyConnector();
                        }
                    }
                }
                return Proxy;
            }
        }

        public override void SetBaseAddress(string address)
        {
            Connector.SetBaseAddress(address);
        }

        public override Task<string> GetAction(string text)
        {
            var result = Task.Run(() => Connector.GetAction(text));
            result.Wait();
            return result;
        }
        public override Task<string> PostAction(string requestUri, string content)
        {
            var result = Task.Run(() => Connector.PostAction(requestUri, content));
            result.Wait();
            return result;
        }

        public override void PatchAction(string requestUri, string content)
        {
            Task.Run(() => Connector.PatchAction(requestUri, content)).Wait();
        }

        public override void PutAction(string requestUri, string content)
        {
            Task.Run(() => Connector.PutAction(requestUri, content)).Wait();
        }

        public override void DeleteAction(string requestUri)
        {
            Task.Run(() => Connector.DeleteAction(requestUri)).Wait();
        }
    }
}
