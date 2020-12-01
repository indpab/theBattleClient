using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Iterator
{
    class ShipIterator : Iterator
    {
        private ShipGroup _shipGroup;
        private IEnumerator<Ship> _enumerator;

        public ShipIterator(ShipGroup shipGroup)
        {
            
        }
        public object Current()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public object Next()
        {
            throw new NotImplementedException();
        }
    }
}
