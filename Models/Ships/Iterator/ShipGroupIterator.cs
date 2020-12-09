using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Iterator
{
    class ShipGroupIterator : Iterator
    {
        private IEnumerator<ShipGroup> _enumerator;
        private Map _map;

        public ShipGroupIterator(Map map)
        {
            _enumerator = map.ShipGroups.GetEnumerator();
            _map = map;

        }

        public int Count()
        {
            return _map.ShipGroups.Count;
        }

        public object Current()
        {
            return _enumerator.Current;
        }

        public bool MoveNext()
        {
            return _enumerator.MoveNext();
        }


        public object Next()
        {
            _enumerator.MoveNext();
            return _enumerator.Current;
        }


    }
}
