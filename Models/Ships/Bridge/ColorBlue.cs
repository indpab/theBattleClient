using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    class ColorBlue : Visualization
    {
        public override string draw(string skin)
        {
            return "Blue " + skin;
        }
    }
}
