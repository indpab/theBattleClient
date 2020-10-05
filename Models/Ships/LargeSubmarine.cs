using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public class LargeSubmarine : Submarine
    {
        public LargeSubmarine(int x, int y, bool horizontal) : base(x, y, horizontal, 3)
        {
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }
    }
}
