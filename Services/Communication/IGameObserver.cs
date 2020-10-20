using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Services.Communication;

namespace TheBattleShipClient.Services
{
    interface IGameObserver
    {
        void Update(GameSubject subject);
    }
}
