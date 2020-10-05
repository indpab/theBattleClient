using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public class SmallDestroyer : Destroyer
    {
        public SmallDestroyer(int x, int y, bool horizontal) : base(x, y, horizontal, 1)
        {
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }
    }
}
