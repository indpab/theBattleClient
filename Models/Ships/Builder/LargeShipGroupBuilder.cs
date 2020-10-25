using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    class LargeShipGroupBuilder : Builder
    {
        public void AddMediumSubmarine()
        {
            LargeSubmarine mediumSubmarine = (LargeSubmarine)abstractShipFactory.CreateSubmarine(0, 0, false);
            shipGroup.Ships.Add(mediumSubmarine);
        }

        public void AddSmallDestroyer()
        {
            MediumDestroyer mediumDestroyer = (MediumDestroyer)abstractShipFactory.CreateDestroyer(0, 0, false);
            shipGroup.Ships.Add(mediumDestroyer);
        }
    }
}
