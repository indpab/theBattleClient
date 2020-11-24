using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Algorithms
{
    class TurnRightState : IMotionState
    {
        public async void Move(Ship ship)
        {
            if (ship.HP <= 0)
            {
                ship.SetMotionState(MotionStateFlyweightFactory.Instance.GetMotionState("doNothing"));
                await ship.Move();
            }
            else
            {
                Console.WriteLine("TurnRightState");
                /*
                throw new NotImplementedException();
                */

                ship.SetMotionState(MotionStateFlyweightFactory.Instance.GetMotionState("straightSlow"));
            }
        }
    }
}
