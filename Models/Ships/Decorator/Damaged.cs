using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Decorator
{
    class Damaged : Decorator
    {
        public Damaged(Ship newship) : base(newship) { }

        public override string setSkin()
        {
            return base.setSkin() + " Damaged";
        }
    }
}
