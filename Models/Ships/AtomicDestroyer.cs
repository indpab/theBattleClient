﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships
{
    public class AtomicDestroyer : Destroyer
    {
        public AtomicDestroyer(int x, int y, bool horizontal) : base(x, y, horizontal, 4)
        {
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }
    }
}
