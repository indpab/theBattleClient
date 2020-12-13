using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Mediator
{
        public abstract class ACommunicator
        {
            public string message;
            protected IMediator mediator;

            public ACommunicator(IMediator m)
            {
                mediator = m;
            }
            public abstract void Send(string message, int type);

            public abstract void Receive(string message, int type);
        }
    }
