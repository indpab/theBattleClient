using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Algorithms
{
    public class MoveStraightFastState : IMotionState
    {
        public async void Move(Ship ship)
        {
            if (Math.Max(Math.Abs(ship.XOffset), Math.Abs(ship.YOffset)) > ship.HP)
            {
                if (ship.HP <= 0)
                {
                    ship.SetMotionState(MotionStateFlyweightFactory.Instance.GetMotionState("doNothing"));
                }
                else
                {
                    ship.SetMotionState(MotionStateFlyweightFactory.Instance.GetMotionState("straightSlow"));
                }
                await ship.Move();
            }
            else
            {
                Console.WriteLine("MoveStraightFastState");
                // Horizontal
                if (ship.XOffset > 1 || ship.XOffset < -1)
                {
                    if (ship.XOffset >= 0)
                        ship.X -= 2;
                    else
                        ship.X += 2;
                }
                else if (ship.YOffset > 1 || ship.YOffset < -1)
                {
                    if (ship.YOffset >= 0)
                        ship.Y -= 2;
                    else
                        ship.Y += 2;
                }
                else
                {
                    if (ship.XOffset > 0 && ship.YOffset > 0)
                        ship.X -= 2;
                    if (ship.XOffset < 0 && ship.YOffset > 0)
                        ship.Y -= 2;
                    if (ship.XOffset < 0 && ship.YOffset < 0)
                        ship.X += 2;
                    if (ship.XOffset > 0 && ship.YOffset < 0)
                        ship.Y += 2;
                }
            }
        }
    }
}
