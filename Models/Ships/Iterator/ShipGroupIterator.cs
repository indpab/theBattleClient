using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Iterator
{
    class ShipGroupIterator : Iterator
    {
        private IEnumerator<ShipGroup> _enumerator;

        public ShipGroupIterator(Map map)
        {
            _enumerator = map.ShipGroups.GetEnumerator();

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
