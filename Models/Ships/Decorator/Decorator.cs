using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Decorator
{
    abstract class Decorator : IShip
    {
        protected IShip tempShip;

        public Decorator(IShip newShip)
        {
            tempShip = newShip;
        }

        public abstract string getSkin();
    }
}
