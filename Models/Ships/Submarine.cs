using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public abstract class Submarine : Ship
    {
        public Submarine(int x, int y, bool horizontal, int hp) : base(x, y, horizontal, hp)
        {
        }
    }
}
