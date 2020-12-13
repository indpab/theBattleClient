using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Visitor
{
    public interface IElement
    {
        public void Accept(IVisitor v);
    }
}
