using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Decorator
{
    class Dead : Decorator
    {
        public Dead(IShip newShip) : base(newShip) {}

        public override string getSkin()
        {
            return tempShip.getSkin() + " Dead";
        }
    }
}
