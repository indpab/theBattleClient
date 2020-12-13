using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Mediator
{
    interface IChatMediator
    {
        public interface IChatMediator
        {
            void AddPlayer(IPlayer player);
            void SendMessage(string message, IPlayer sender);
        }
    }
}
