using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Algorithms
{
    public class TurnLeftState : IMotionState
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
                Console.WriteLine("TurnLeftState");
                /*
                // Horizontal
                if (ship.XOffset > 1 || ship.XOffset < -1)
                {
                    int x;
                    int y;
                    if(ship.XOffset > 0)
                    {
                        x = (int)((ship.X + (ship.X + ship.XOffset - 1)) / 2);
                        y = (int)(ship.Y - (ship.XOffset / 2) + 1);
                        ship.YOffset = ship.XOffset;
                        ship.XOffset = -1;
                    }
                    else
                    {
                        x = (int)((ship.X + (ship.X + ship.XOffset - 1)) / 2);
                        y = (int)(ship.Y + (ship.XOffset / 2) - 1);
                        ship.YOffset = ship.XOffset;
                        ship.XOffset = -1;
                    }
                }
                // Vertical
                else if (ship.YOffset > 1 || ship.YOffset < -1)
                {
                    if (ship.YOffset >= 0)
                        ship.Y -= 1;
                    else
                        ship.Y += 1;
                }
                else
                {
                    if (ship.XOffset > 0 && ship.YOffset > 0)
                        ship.X -= 1;
                    if (ship.XOffset < 0 && ship.YOffset > 0)
                        ship.Y -= 1;
                    if (ship.XOffset < 0 && ship.YOffset < 0)
                        ship.X += 1;
                    if (ship.XOffset > 0 && ship.YOffset < 0)
                        ship.Y += 1;
                }
                */

                ship.SetMotionState(MotionStateFlyweightFactory.Instance.GetMotionState("straightSlow"));
            }
        }
    }
}
