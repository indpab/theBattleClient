using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class SmallShipFactory : AbstractShipFactory
    {
        public override Submarine CreateSubmarine(int x, int y, bool horizontal)
        {
            return new SmallSubmarine(x, y, horizontal);
        }

        public override Destroyer CreateDestroyer(int x, int y, bool horizontal)
        {
            return new SmallDestroyer(x, y, horizontal);
        }
    }
}
