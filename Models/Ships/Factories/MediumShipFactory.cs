using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class MediumShipFactory : AbstractShipFactory
    {
        public override Submarine CreateSubmarine()
        {
            return new MediumSubmarine();
        }

        public override Destroyer CreateDestroyer()
        {
            return new MediumDestroyer();
        }
    }
}
