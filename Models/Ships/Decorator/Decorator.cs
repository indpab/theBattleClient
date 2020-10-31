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

        public Ship getShip()
        {
            return tempShip;
        }

        public virtual string setSkin()
        {
            return tempShip.setSkin();
        }
    }
}
