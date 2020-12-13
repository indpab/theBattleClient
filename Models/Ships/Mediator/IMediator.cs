using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Mediator
{
    public interface IMediator
    {
        void AddComunicator(ACommunicator a);
        void SendMessage(ACommunicator caller, string message, int type);
    }
}
