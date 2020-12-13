using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Visitor
{
    class VisitorMedium : IhpVisitor
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
