using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Iterator
{
    interface Aggregate
    {
        public Iterator CreateIterator();
    }
}
