using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships;
using TheBattleShipClient.Models.Ships.Bridge;
using TheBattleShipClient.Models.Ships.Decorator;

namespace TheBattleShipClient.Models.Chain_of_Responsibility
{
    class NamedShipHandler : Handler
    {
        public override void Handle(Ship shipResponse, IShip current_decor, Visualization visualization)
        {
            current_decor = new Named(shipResponse);
            if (succesor != null)
            {
                succesor.Handle(shipResponse, current_decor, visualization);
            }
        }
    }
}
