using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    class Invoker
    {
        private List<IShipCommand> commands = new List<IShipCommand>();

<<<<<<< Updated upstream
        public void ClickButton(IShipCommand command)
        {
            this.commands.Add(command);
            command.execute();
=======
        public void ClickPlaceShip(IShipCommand placeShip)
        {
            this.commands.Add(placeShip);
            placeShip.execute();
        }

        public void ClickTurnShip(IShipCommand turnShip)
        {
            this.commands.Add(turnShip);
            turnShip.execute();
>>>>>>> Stashed changes
        }

        public void ClickUndo()
        {
<<<<<<< Updated upstream
            if (commands.Count > 0)
            {
                commands[commands.Count - 1].undo();
                commands.RemoveAt(commands.Count - 1);
            }
=======
            commands[commands.Count - 1].undo();
            commands.RemoveAt(commands.Count - 1);
>>>>>>> Stashed changes
        }
    }
}
