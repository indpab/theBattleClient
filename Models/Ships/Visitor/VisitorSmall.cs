using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Visitor
{
    class VisitorSmall : IVisitor
    {
        public void VisitDestroyer(Destroyer d)
        {
            d.ShipType = new ShipType
            {
                IsSubmarine = false,
                Name = "Small Destroyer",
                Size = 1
            };
        }

        public void VisitSubmarine(Submarine s)
        {
            s.ShipType = new ShipType
            {
                IsSubmarine = true,
                Name = "Small Submarine",
                Size = 1
            };
        }
    }
}
