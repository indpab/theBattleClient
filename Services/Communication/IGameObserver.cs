using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Services.Communication;

namespace TheBattleShipClient.Services
{
    public interface IGameObserver
    {
        public void UpdateState();
    }
}
