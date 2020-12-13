using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Mediator
{
    public interface IPlayer
    {
        void SendMessage(string message);
        string ReceiveMessage(string message);
    }
}

