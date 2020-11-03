using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    class ColorBlue : Visualization
    {
        public ColorBlue(Decorator.IShip ship) : base(ship) { }
        public override string draw()
        {
            return "Blue " + ship.getSkin();
        }
    }
}
