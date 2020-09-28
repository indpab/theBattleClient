using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class LargeShipFactory : AbstractShipFactory
    {
        public override Submarine CreateSubmarine()
        {
            return new LargeSubmarine();
        }

        public override Destroyer CreateDestroyer()
        {
            return new LargeDestroyer();
        }
    }
}
