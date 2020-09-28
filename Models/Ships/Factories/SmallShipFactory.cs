using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class SmallShipFactory : AbstractShipFactory
    {
        public override Submarine CreateSubmarine()
        {
            return new SmallSubmarine();
        }

        public override Destroyer CreateDestroyer()
        {
            return new SmallDestroyer();
        }
    }
}
