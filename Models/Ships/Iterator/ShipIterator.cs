using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Iterator
{
    class ShipIterator : Iterator
    {
        private ShipGroup _shipGroup;
        private Ship[] _ships;
        private int _count;


        public ShipIterator(ShipGroup shipGroup)
        {
            shipGroup.Ships.CopyTo(_ships,0);
            _shipGroup = shipGroup;
        }

        public int Count()
        {
            return _shipGroup.Ships.Count;
        }

        public object Current()
        {
            return _ships[_count];
        }

        public bool MoveNext()
        {
            try
            {
                _ = _ships[_count++];
                return true;
            }
            catch (Exception e)
            {
                _count--;
                return false;
            }
        }

        public object Next()
        {
            if (MoveNext())
            {
                return Current();
            }
            return false;
        }
    }
}
