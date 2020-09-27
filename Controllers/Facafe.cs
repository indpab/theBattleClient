using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Controllers
{
    class Facafe
    {
        public AbstractServerConnector Connector { get; set; }

        public Facafe()
        {
            Connector = ProxyConnector.Instance;
        }
    }
}
