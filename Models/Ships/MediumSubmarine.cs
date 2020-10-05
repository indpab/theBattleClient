using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public class MediumSubmarine : Submarine
    {
        public MediumSubmarine(int x, int y, bool horizontal) : base(x, y, horizontal, 2)
        {
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }
    }
}
