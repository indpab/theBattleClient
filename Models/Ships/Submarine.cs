using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    [Serializable]
    public abstract class Submarine : Ship
    {
        public Submarine(string token, string roomId, int x, int y, bool horizontal, int hp)
            : base(token, roomId, x, y, horizontal, hp)
        {
        }

        internal Submarine DeepClone()
        {
            return (Submarine)base.DeepClone();
        }
    }
}
