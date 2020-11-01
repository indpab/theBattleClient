using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Decorator
{
    abstract class Decorator : IShip
    {
        protected Ship tempShip;

        public Decorator(Ship newShip)
        {
            tempShip = newShip;
        }

        public virtual string getSkin()
        {
            return tempShip.getSkin();
        }
    }
}
