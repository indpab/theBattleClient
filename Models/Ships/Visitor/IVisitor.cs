using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Visitor
{

    public interface IVisitor

    {
        public void VisitDestroyer(Destroyer d);
        public void VisitSubmarine(Submarine s);

    }
}
