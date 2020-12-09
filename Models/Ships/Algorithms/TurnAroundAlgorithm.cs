using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShipClient.Models.Ships.Algorithms
{
    [Serializable]
    public class TurnAroundAlgorithm : IMotionAlgorithm
    {
        public async Task Move(Ship ship)
        {
            // Horizontal
            if (ship.XOffset > 1 || ship.XOffset < -1)
            {
                if (ship.XOffset >= 0)
                    ship.X = ship.X + ship.XOffset - 1;
                else
                    ship.X = ship.X + ship.XOffset + 1;
                ship.XOffset = -ship.XOffset;
            }
            else if (ship.YOffset > 1 || ship.YOffset < -1)
            {
                if (ship.YOffset >= 0)
                    ship.Y = ship.Y + ship.YOffset - 1;
                else
                    ship.Y = ship.Y + ship.YOffset + 1;
                ship.YOffset = -ship.YOffset;
            }
            else
            {
                ship.XOffset = -ship.XOffset;
                ship.YOffset = -ship.YOffset;
            }
        }
    
    }
}
