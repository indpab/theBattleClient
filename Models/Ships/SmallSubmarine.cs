using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public class SmallSubmarine : Submarine
    {
        public SmallSubmarine(int x, int y, bool horizontal) : base(x, y, horizontal, 1)
        {
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }
    }
}
