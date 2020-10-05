using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public abstract class Destroyer : Ship
    {
        public Destroyer(int x, int y, bool horizontal, int hp) : base(x, y, horizontal, hp)
        {
        }
    }
}
