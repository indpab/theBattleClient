using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Visitor;

namespace TheBattleShipClient.Models.Ships
{
    [Serializable]
    public abstract class Destroyer : Ship, IElement
    {
        public Destroyer(string token, string roomId, int x, int y, bool horizontal, int hp)
            : base(token, roomId, x, y, horizontal, hp)
        {
            
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitDestroyer(this);
        }

        internal Destroyer DeepClone()
        {
            return (Destroyer)base.DeepClone();
        }
    }
}
