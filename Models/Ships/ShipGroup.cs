using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public class ShipGroup
    {
        public ShipType ShipType { get; set; }
        public int Count { get; set; }
        public int Limit { get; set; }
        public ICollection<Ship> Ships { get; set; }
    }
}
