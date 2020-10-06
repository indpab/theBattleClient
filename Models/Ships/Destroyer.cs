using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public abstract class Destroyer : Ship
    {
        public Destroyer(string token, string roomId, int x, int y, bool horizontal, int hp)
            : base(token, roomId, x, y, horizontal, hp)
        {
        }
    }
}
