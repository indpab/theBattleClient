using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships;
using TheBattleShipClient.Models.Ships.Builder;
using TheBattleShipClient.Models.Ships.Factories;

namespace TheBattleShipClient.Models
{
    public class SmallShipGroupBuilder : Builder
    {
        public void AddSmallSubmarine()
        {
            SmallSubmarine smallSubmarine = (SmallSubmarine)abstractShipFactory.CreateSubmarine(0, 0, false);
            shipGroup.Ships.Add(smallSubmarine);
        }

        public void AddSmallDestroyer()
        {
            SmallDestroyer smallDestroyer = (SmallDestroyer)abstractShipFactory.CreateDestroyer(0, 0, false);
            shipGroup.Ships.Add(smallDestroyer);
        }

    }
}
