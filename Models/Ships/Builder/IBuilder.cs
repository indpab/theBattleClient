using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Builder
{
    interface IBuilder
    {
        void InitializeShipGroup(ShipGroup shipGroup);
        void SetLimitations(int count, int limit);
        void SetShipType(ShipType shipType);
        ShipGroup Build();
    }
}
