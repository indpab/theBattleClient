﻿using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships;
using TheBattleShipClient.Models.Ships.Bridge;
using TheBattleShipClient.Models.Ships.Decorator;

namespace TheBattleShipClient.Models.Chain_of_Responsibility
{
    class DeadDamagedShipHandler : Handler
    {
        public override void Handle(Ship shipResponse, IShip current_decor, Visualization visualization)
        {
            visualization.draw(shipResponse.GetButtons(), new Damaged(current_decor));
        }

    }
}
