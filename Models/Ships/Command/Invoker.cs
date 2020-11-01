using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    class Invoker
    {
        IPlaceShipCommand placeShip;
        IPlaceShipCommand turnShip;
        int lastCommand;

        public Invoker(IPlaceShipCommand placeShip, IPlaceShipCommand turnShip)
        {
            this.placeShip = placeShip;
            this.turnShip = turnShip;
            lastCommand = -1;
        }

        public void ClickPlaceShip()
        {
            this.placeShip.execute();
            lastCommand = 0;
        }

        public void ClickTurnShip()
        {
            this.turnShip.execute();
            lastCommand = 1;
        }

        public void ClickUndo()
        {
            if(lastCommand == 0)
            {
                placeShip.undo();
            }
            else if (lastCommand == 1)
            {
                turnShip.undo();
            }
        }
    }
}
