using System;
using System.Collections.Generic;
using System.Text;
using TheBattleShipClient.Models.Ships.Interpreter;

namespace TheBattleShipClient.Models.Communication.Interpreter
{
    class CurseExpression : Expression
    {
        public override string Interpret(string message)
        {
            string response = "";

            response = message.Replace("curse", "*****");

            return response;
        }
    }
}
