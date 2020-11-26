using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    public class ChangePositionShipCommand : ShipCommand
    {
        private int x;
        private int y;

        public ChangePositionShipCommand(Ship ship, int x, int y)
            :base(ship)
        {
            this.x = x;
            this.y = y;
        }

        public override void execute()
        {
            _ship.setCordinates(x, y);
        }
    }
}
