using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Visitor
{
    interface IElement
    {
        public abstract void Accept(IhpVisitor v);
    }
}
