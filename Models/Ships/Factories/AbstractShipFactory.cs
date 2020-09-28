using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public abstract class AbstractShipFactory
    {
        public abstract Submarine CreateSubmarine();
        public abstract Destroyer CreateDestroyer();
    }
}
