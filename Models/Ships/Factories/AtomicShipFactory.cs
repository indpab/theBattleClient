using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class AtomicShipFactory : AbstractShipFactory
    {
        public override Submarine CreateSubmarine()
        {
            return null;
        }

        public override Destroyer CreateDestroyer()
        {
            return new AtomicDestroyer();
        }
    }
}
