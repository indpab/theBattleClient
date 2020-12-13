using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Mediator
{
    public class ChatMediator : IChatMediator
    {
        List<IPlayer> players;

        public ChatMediator()
        {
            players = new List<IPlayer>();
        }

        public void AddPlayer(IPlayer player)
        {
            players.Add(player);
        }

        public void SendMessage(string message, IPlayer sender)
        {
            string chat = string.Empty;
            foreach (IPlayer player in players)
            {
                if (player != sender)
                    chat += player.ReceiveMessage(message);
            }
        }
    }
}
