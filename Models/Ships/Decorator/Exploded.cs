using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Decorator
{
    class Exploded : Decorator
    {
        public Exploded(IShip newship) : base(newship) {}

        public override string getSkin()
        {
            return tempShip.getSkin() + " Exploded";
        }
    }
}
