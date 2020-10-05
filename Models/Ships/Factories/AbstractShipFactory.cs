﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public abstract class AbstractShipFactory
    {
        public abstract Submarine CreateSubmarine(int x, int y, bool horizontal);
        public abstract Destroyer CreateDestroyer(int x, int y, bool horizontal);
    }
}
