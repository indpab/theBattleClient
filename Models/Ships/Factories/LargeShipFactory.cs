using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class LargeShipFactory : AbstractShipFactory
    {
        public override Submarine CreateSubmarine(int x, int y, bool horizontal)
        {
            return new LargeSubmarine(x, y, horizontal);
        }

        public override Destroyer CreateDestroyer(int x, int y, bool horizontal)
        {
            return new LargeDestroyer(x, y, horizontal);
        }
    }
}
