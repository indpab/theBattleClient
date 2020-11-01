﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Command
{
    class Invoker
    {
        private List<IShipCommand> commands = new List<IShipCommand>();

        public void ClickButton(IShipCommand command)
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