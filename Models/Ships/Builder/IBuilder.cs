using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Builder
{
    interface IBuilder
    {
        void SetLimitations();
        void SetShipType();
        void AddShip();
        ShipGroup Build();
    }
}
