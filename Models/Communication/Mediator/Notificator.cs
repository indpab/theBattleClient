using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBattleShipClient.Models.Ships.Mediator;
using TheBattleShipClient.Services;

namespace TheBattleShipClient.Models.Communication.Mediator
{
    class Notificator : Communicator
    {
        public Notificator(IMediator mediator, TextBox chatTextBox) : base(mediator, chatTextBox) { }
        public override async Task Send(string message, string roomId, string token)
        {
            await mediator.SendMessage(this, message, roomId, token);
        }

        public override async Task Receive(string message, string roomId, string token)
        {
            await CommunicationService.PostMessage(token, roomId, message);
        }
    }
}
