using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Mediator
{
    public class Event : ACommunicator
    {
        public Event(IMediator mediator) : base(mediator) { }

        public override void Send(string message, int type)
        {
            mediator.SendMessage(this, message, type);
        }

        public override void Receive(string message, int type)
        {
            this.message = message;
        }
    }
}
