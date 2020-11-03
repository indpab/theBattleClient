using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    abstract class Visualization
    {
        public abstract string draw(string skin);
    }
}
