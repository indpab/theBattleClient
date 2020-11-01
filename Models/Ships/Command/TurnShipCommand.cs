using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    class TurnShipCommand : IPlaceShipCommand
    {
        Ship ship;

        public TurnShipCommand(Ship newShip)
        {
            ship = newShip;
        }
        public void execute()
        {
            ship.Rotate(!ship.horizontal);
        }

        public void undo()
        {
            ship.Rotate(!ship.horizontal);
        }
    }
}
