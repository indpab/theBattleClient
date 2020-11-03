using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    abstract class Visualization
    {
        protected Decorator.IShip ship;

        public Visualization(Decorator.IShip ship)
        {
            this.ship = ship;
        }

        public abstract string draw();
    }
}
