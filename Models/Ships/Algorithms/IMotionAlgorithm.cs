﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShipClient.Models.Ships.Algorithms
{
    public interface IMotionAlgorithm
    {
        Task Move(Ship ship);
    }
}
