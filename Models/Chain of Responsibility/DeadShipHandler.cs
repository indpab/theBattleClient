using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships;
using TheBattleShipClient.Models.Ships.Bridge;
using TheBattleShipClient.Models.Ships.Decorator;

namespace TheBattleShipClient.Models.Chain_of_Responsibility
{
    class DeadShipHandler : Handler
    {
        public override void Handle(Ship shipResponse, IShip current_decor, Visualization visualization)
        {
            current_decor = new Dead(current_decor);
            if (shipResponse.DeadDamaged() && succesor != null)
            {
                succesor.Handle(shipResponse, current_decor, visualization);
            }
            else
            {
                visualization.draw(shipResponse.GetButtons(), current_decor);

            }
        }

    }
}
