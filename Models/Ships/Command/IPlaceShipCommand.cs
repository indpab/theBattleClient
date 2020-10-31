using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    interface IPlaceShipCommand
    {
        public void execute();
        public void undo();
    }
}
