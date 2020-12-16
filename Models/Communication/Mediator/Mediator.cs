using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Mediator
{
    class Mediator : IMediator
    {
        List<Communicator> communicators = new List<Communicator>();

        public void AddComunicator(Communicator a)
        {
            communicators.Add(a);
        }

        public async Task SendMessage(Communicator sender, string msg, string roomId, string token)
        {
            for (int i = 0; i < communicators.Count; i++)
            {
                if (communicators[i] != sender)
                {
                    await communicators[i].Receive(msg, roomId, token);
                }
                
            }
        }
    }
}
