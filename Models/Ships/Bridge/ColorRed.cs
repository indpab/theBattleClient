using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    class ColorRed : Visualization
    {
        public override string draw(string skin)
        {
            return "Red " + skin;
        }
    }
}
