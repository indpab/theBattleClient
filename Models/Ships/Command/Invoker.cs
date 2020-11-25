using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    class Invoker
    {
        private List<ShipCommand> commands = new List<ShipCommand>();

        public void ClickButton(ShipCommand command)
        {
            this.commands.Add(command);
            command.execute();
        }

        public void ClickUndo()
        {
            if (commands.Count > 0)
            {
                commands[commands.Count - 1].undo();
                commands.RemoveAt(commands.Count - 1);
            }
        }
    }
}
