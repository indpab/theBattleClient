using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Algorithms
{
    public class MoveStraightSlowAlgorithm : IMotionAlgorithm
    {
        public void Move(Ship ship)
        {
            // Horizontal
            if(ship.XOffset > 1 || ship.XOffset < -1)
            {
                if (ship.XOffset >= 0)
                    ship.X -= 1;
                else
                    ship.X += 1;
            }
            // Vertical
            else if(ship.YOffset > 1 || ship.YOffset < -1)
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
        }
    }
}
