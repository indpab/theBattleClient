using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Decorator
{
    class Dead : Decorator
    {
        public Dead(Ship newShip) : base(newShip) {}

        public override string setSkin()
        {
            return base.setSkin() + " Dead";
        }
    }
}
