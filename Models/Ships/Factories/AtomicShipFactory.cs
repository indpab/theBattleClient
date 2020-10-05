using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class AtomicShipFactory : AbstractShipFactory
    {
        public override Submarine CreateSubmarine(int x, int y, bool horizontal)
        {
            return new AtomicSubmarine(x, y, horizontal);
        }

        public override Destroyer CreateDestroyer(int x, int y, bool horizontal)
        {
            return new AtomicDestroyer(x, y, horizontal);
        }
    }
}
