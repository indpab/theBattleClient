using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships;

namespace TheBattleShipClient.Models.Chain_of_Responsibility
{
    public abstract class Handler
    {
        public abstract void Handle(Ship shipResponse);
        public abstract void SetSuccessor(Handler successor);
    }
}
