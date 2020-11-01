using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    interface IShipCommand
    {
        public void execute();
        public void undo();
    }
}