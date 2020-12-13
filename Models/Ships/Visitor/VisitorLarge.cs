using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Visitor
{
    class VisitorLarge : IhpVisitor
    {
        public void VisitDestroyer(Destroyer d)
        {
            throw new NotImplementedException();
        }

        public void VisitSubmarine(Submarine s)
        {
            throw new NotImplementedException();
        }
    }
}
