using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    class Invoker
    {
        private List<IShipCommand> commands = new List<IShipCommand>();
        IShipCommand temp;
        public void ClickButton(IShipCommand command)
        {
            this.commands.Add(command);
            command.execute();
        }

        public IShipCommand ClickUndo()
        {
            if (commands.Count > 0)
            {
                temp = commands[commands.Count - 1];
                commands[commands.Count - 1].undo();
                commands.RemoveAt(commands.Count - 1);
            }
            return temp;
        }

        public int getCommandsCount()
        {
            return commands.Count;
        }
    }
}
