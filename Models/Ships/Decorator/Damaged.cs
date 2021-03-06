﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Decorator
{
    class Damaged : Decorator
    {
        public Damaged(IShip newship) : base(newship) { }

        public override string getSkin()
        {
            return tempShip.getSkin() + " Damaged";
        }
    }
}
