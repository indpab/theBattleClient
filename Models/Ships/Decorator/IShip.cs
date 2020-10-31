using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Decorator
{
    interface IShip
    {
        public Ship getShip();

        public string setSkin();
    }
}
