using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShipClient.Controllers
{
    public abstract class AbstractServerConnector
    {
        public abstract Task<string> GetAction(string text);
        public abstract Task<string> PostAction(string requestUri, string content);
        public abstract void PutAction(string requestUri, string content);
        public abstract void PatchAction(string requestUri, string content);
        public abstract void DeleteAction(string requestUri);
        public abstract void SetBaseAddress(string address);
    }
}
