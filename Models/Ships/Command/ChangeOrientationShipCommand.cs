using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    public class ChangeOrientationShipCommand : ShipCommand
    {
        public ChangeOrientationShipCommand(Ship ship)
            :base(ship)
        {
        }

        public override void execute()
        {
            _ship.Rotate(!_ship.horizontal);
        }
    }
}
