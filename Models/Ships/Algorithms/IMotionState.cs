using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Algorithms
{
    public interface IMotionState
    {
        void Move(Ship ship);
    }
}
