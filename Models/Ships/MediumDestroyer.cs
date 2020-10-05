using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public class MediumDestroyer : Destroyer
    {
        public MediumDestroyer(int x, int y, bool horizontal) : base(x, y, horizontal, 2)
        {
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }
    }
}
