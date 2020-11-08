using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Decorator
{
    class Named : Decorator
    {
        public Named(IShip newship) : base(newship) {}

        public override string getSkin()
        {
            return tempShip.getSkin() + " Ship";
        }
    }
}
