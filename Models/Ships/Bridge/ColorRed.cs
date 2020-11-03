using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    class ColorRed : Visualization
    {
        public ColorRed(Decorator.IShip ship) : base(ship) { }
        public override string draw()
        {
            return "Red " + ship.getSkin();
        }
    }
}
