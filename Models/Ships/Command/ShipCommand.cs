using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    public abstract class ShipCommand
    {
        protected Ship _ship;
        protected ShipSnapshotMemento _shipMemento;

        public ShipCommand(Ship ship)
        {
            _ship = ship;
            _shipMemento = _ship.GetSnapshot();
        }

        public void undo()
        {
            _ship.SetSnapshot(_shipMemento);
        }

        public abstract void execute();
    }
}