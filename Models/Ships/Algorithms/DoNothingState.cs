using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Algorithms
{

    [Serializable]
    public class DoNothingState : IMotionState
    {
        public void Move(Ship ship)
        {
        }
    }
}
