using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Template
{
    public class IFleetTemplate
    {
        public virtual List<ShipGroup> CreateFleet(int smallCount, int mediumCount, int largeCount, int atomicCount)
        {
            return new List<ShipGroup>();
        }
    }
}
