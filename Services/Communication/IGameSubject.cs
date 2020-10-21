using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Services.Communication
{
    interface IGameSubject
    {
        void Attach(IGameObserver observer);
        void NotifyObservers();
    }
}
