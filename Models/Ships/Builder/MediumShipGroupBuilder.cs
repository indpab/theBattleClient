using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models.Ships.Builder
{
    class MediumShipGroupBuilder : Builder
    {
        public void AddMediumSubmarine()
        {
            MediumSubmarine mediumSubmarine = (MediumSubmarine)abstractShipFactory.CreateSubmarine(0, 0, false);
            shipGroup.Ships.Add(mediumSubmarine);
        }
        public void AddMediumDestroyer()
        {
            MediumDestroyer mediumDestroyer = (MediumDestroyer)abstractShipFactory.CreateDestroyer(0, 0, false);
            shipGroup.Ships.Add(mediumDestroyer);
        }
    }
}
