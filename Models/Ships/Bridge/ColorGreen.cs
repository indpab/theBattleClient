using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    class ColorGreen : Visualization
    {
        public ColorGreen(Decorator.IShip ship) : base(ship) { }
        public override string draw()
        {
            return "Green " + ship.getSkin();
        }
    }
}
