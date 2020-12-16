using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShipClient.Models.Ships.Mediator
{
    public interface IMediator
    {
        void AddComunicator(Communicator a);
        Task SendMessage(Communicator sender, string msg, string roomId, string token);
    }
}
