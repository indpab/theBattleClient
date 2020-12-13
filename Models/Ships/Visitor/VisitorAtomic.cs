using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Visitor
{
    class VisitorAtomic : IVisitor
    {
        public void VisitDestroyer(Destroyer d)
        {
            d.ShipType = new ShipType
            {
                IsSubmarine = false,
                Name = "Atomic Destroyer",
                Size = 4
            };
        }

        public void VisitSubmarine(Submarine s)
        {
            s.ShipType = new ShipType
            {
                IsSubmarine = true,
                Name = "Atomic Submarine",
                Size = 4
            };
        }
    }
}
