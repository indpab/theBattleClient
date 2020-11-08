using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Command
{
    [Serializable]
    class PlaceShipCommand : IShipCommand
    {
        Ship ship;
        int x, y;

        Ship oldShip;

        List<Button> buttons;
        public PlaceShipCommand(Ship newShip, int x, int y, List<Button> buttons)
        {
            ship = newShip;
            this.x = x;
            this.y = y;
            this.buttons = buttons;
        }

        public void execute()
        {
            oldShip = ship;

            ship.setCordinates(x, y);
        }

        public void undo()
        {
            ship.setCordinates(oldShip.X, oldShip.Y);
        }
        public Ship getShip()
        {
            return oldShip;
        }
    }
}
