using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    public class ShipSnapshotMemento
    {
        private ShipSnapshot _state;

        public ShipSnapshotMemento(ShipSnapshot state)
        {
            _state = state;
        }

        public ShipSnapshot GetSnapshot()
        {
            return _state;
        }
    }
}
