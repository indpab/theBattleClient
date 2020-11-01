using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Decorator
{
    class Damaged : Decorator
    {
        public Damaged(Ship newship) : base(newship) { }

        public override string getSkin()
        {
            return base.getSkin() + " Damaged";
        }
    }
}
