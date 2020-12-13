using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Visitor
{
    public class ShipTypeMappings
    {
        public static Dictionary<string, int> typeIdPairs = new Dictionary<string, int>
        {
            {"Small Destroyer" ,1},
            {"Medium Destroyer",2},
            {"Large Destroyer" ,3},
            {"Atomic Destroyer",4},
            {"Small Submarine" ,5},
            {"Medium Submarine",6},
            {"Large Submarine" ,7},
            {"Atomic Submarine",8}
        };
    }
}
