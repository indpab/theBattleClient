using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class MediumShipFactory : AbstractShipFactory
    {
        public override Submarine CreateSubmarine(int x, int y, bool horizontal)
        {
            return new MediumSubmarine(x, y, horizontal);
        }

        public override Destroyer CreateDestroyer(int x, int y, bool horizontal)
        {
            return new MediumDestroyer(x, y, horizontal);
        }
    }
}
