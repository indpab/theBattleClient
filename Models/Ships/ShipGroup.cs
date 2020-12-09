using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Iterator;

namespace TheBattleShipClient.Models.Ships
{
    public class ShipGroup : Aggregate
    {
        public ShipType ShipType { get; set; }
        public int Count { get; set; }
        public int Limit { get; set; }
        public ICollection<Ship> Ships { get; set; }

        public Iterator.Iterator CreateIterator()
        {
            return new ShipIterator(this);
        }
    }
}
