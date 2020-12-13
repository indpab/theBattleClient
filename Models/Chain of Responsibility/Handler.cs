using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships;
using TheBattleShipClient.Models.Ships.Bridge;
using TheBattleShipClient.Models.Ships.Decorator;

namespace TheBattleShipClient.Models.Chain_of_Responsibility
{
    public abstract class Handler
    {
        protected Handler succesor;
        public abstract void Handle(Ship shipResponse, IShip current_decor, Visualization visualization);
        public void SetSuccessor(Handler succesor)
        {
            this.succesor = succesor;
        }
    }
}
