using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    class PlaceShipCommand : IShipCommand
    {
        Ship ship;
        int x, y;

        List<int> oldX;
        List<int> oldY;
        public PlaceShipCommand(Ship newShip, int x, int y)
        {
            ship = newShip;
            this.x = x;
            this.y = y;
            oldX = new List<int>();
            oldY = new List<int>();
        }
        public void execute()
        {
            oldX.Add(ship.X);
            oldY.Add(ship.Y);

            ship.setCordinates(x, y);
        }

        public void undo()
        {
            ship.setCordinates(oldX[oldX.Count-1],oldY[oldY.Count-1]);
            oldX.RemoveAt(oldX.Count - 1);
            oldY.RemoveAt(oldY.Count - 1);
        }
    }
}
