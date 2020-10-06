using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Algorithms
{
    public interface IMotionAlgorithm
    {
        void Move(Ship ship);
    }
}
