using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Visitor;

namespace TheBattleShipClient.Models.Ships
{
    public abstract class Submarine : Ship, IElement
    {
        public Submarine(string token, string roomId, int x, int y, bool horizontal, int hp)
            : base(token, roomId, x, y, horizontal, hp)
        {
        }
        public void Accept(IhpVisitor visitor)
        {
            visitor.VisitSubmarine(this);
        }
        internal Submarine DeepClone()
        {
            return (Submarine)base.DeepClone(this);
        }
    }
}
