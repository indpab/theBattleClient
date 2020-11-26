using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    public class ShipSnapshot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int XOffset { get; set; }
        public int YOffset { get; set; }
    }
}
