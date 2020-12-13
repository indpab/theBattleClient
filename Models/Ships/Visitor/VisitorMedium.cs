using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Visitor
{
    class VisitorMedium : IVisitor
    {
        public void VisitDestroyer(Destroyer d)
        {
            d.ShipType = new ShipType
            {
                IsSubmarine = false,
                Name = "Medium Destroyer",
                Size = 2
            };
        }

        public void VisitSubmarine(Submarine s)
        {
            s.ShipType = new ShipType
            {
                IsSubmarine = true,
                Name = "Medium Submarine",
                Size = 2
            };
        }
    }
}
