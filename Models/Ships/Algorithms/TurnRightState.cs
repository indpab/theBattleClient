using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Algorithms
{
    public class TurnRightState : IMotionState
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

                // Horizontal
                if (ship.XOffset > 1 || ship.XOffset < -1)
                {
                    ship.YOffset = -ship.XOffset;
                    if(ship.XOffset > 0)
                        ship.XOffset = 1;
                    else
                        ship.XOffset = -1;
                }
                // Vertical
                else if (ship.YOffset > 1 || ship.YOffset < -1)
                {
                    ship.XOffset = ship.YOffset;
                    if(ship.YOffset > 0)
                        ship.YOffset = 1;
                    else
                        ship.YOffset = -1;
                }
                else
                {
                    if (ship.XOffset > 0 && ship.YOffset > 0)
                    {
                        ship.YOffset = -ship.YOffset;
                    }
                    else if (ship.XOffset < 0 && ship.YOffset < 0)
                    {
                        ship.YOffset = -ship.YOffset;
                    }
                    else if (ship.XOffset > 0 && ship.YOffset < 0)
                    {
                        ship.XOffset = -ship.XOffset;
                    }
                    else if (ship.XOffset < 0 && ship.YOffset > 0)
                    {
                        ship.XOffset = -ship.XOffset;
                    }
                }
                /*
                throw new NotImplementedException();
                */

                ship.SetMotionState(MotionStateFlyweightFactory.Instance.GetMotionState("straightSlow"));
            }
        }
    }
}
