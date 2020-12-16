using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Interpreter
{
    abstract class Expression
    {
        public abstract string Interpret(string message);
    }
}
