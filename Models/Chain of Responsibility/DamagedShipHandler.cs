using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships;
using TheBattleShipClient.Models.Ships.Bridge;
using TheBattleShipClient.Models.Ships.Decorator;

namespace TheBattleShipClient.Models.Chain_of_Responsibility
{
    class DamagedShipHandler : Handler
    {
        public override void Handle(Ship shipResponse, IShip current_decor, Visualization visualization)
        {

            if (shipResponse.isDamaged())
            {
                if (shipResponse.isDead() && succesor!= null)
                {
                    succesor.Handle(shipResponse, current_decor, visualization);
                }
                else
                {
                    current_decor = new Damaged(current_decor);
                    visualization.draw(shipResponse.GetButtons(), current_decor);
                }
                
            }
        }

    }
}
