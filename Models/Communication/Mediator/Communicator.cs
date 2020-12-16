using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Mediator
{
    public abstract class Communicator
    {
        protected IMediator mediator;
        public string message;
        protected TextBox chatTextBox;

        public Communicator(IMediator mediator, TextBox chatTextBox)
        {
            this.mediator = mediator;
            this.chatTextBox = chatTextBox;
        }

        public abstract Task Send(string message, string roomId, string token);

        public abstract Task Receive(string message, string RoomId, string token);
    }
}
