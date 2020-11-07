using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    [Serializable]
    class TurnShipCommand : IShipCommand
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
