using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Visitor
{
    class VisitorLarge : IVisitor
    {
        public void VisitDestroyer(Destroyer d)
        {
            d.ShipType = new ShipType
            {
                IsSubmarine = false,
                Name = "Large Destroyer",
                Size = 3
            };
        }

        public void VisitSubmarine(Submarine s)
        {
            s.ShipType = new ShipType
            {
                IsSubmarine = true,
                Name = "Large Submarine",
                Size = 3
            };
        }
    }
}
