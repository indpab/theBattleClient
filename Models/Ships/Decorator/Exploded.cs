using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Decorator
{
    class Exploded : Decorator
    {
        public Exploded(Ship newship) : base(newship) {}

        public override string setSkin()
        {
            return base.setSkin() + " Exploded";
        }
    }
}
