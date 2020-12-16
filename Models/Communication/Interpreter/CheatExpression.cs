using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TheBattleShipClient.Models.Ships.Interpreter;

namespace TheBattleShipClient.Models.Communication.Interpreter
{
    class CheatExpression : Expression
    {
        List<Button> buttons;
        public void setButtons(List<Button> buttons)
        {
            this.buttons = buttons;
        }
        public override string Interpret(string message)
        {
            string response = message;

            foreach (var but in buttons)
            {
                if (response.Contains(but.Text))
                {
                    response = response.Replace(but.Text, "**");
                }
                else if (response.Contains(but.Text.ToLower()))
                {
                    response = response.Replace(but.Text.ToLower(), "**");
                }
                else if (response.Contains(but.Text[0] + " " + but.Text[1].ToString()))
                {
                    response = response.Replace((but.Text[0] + " " + but.Text[1].ToString()), "**");
                }
                else if (response.Contains(but.Text[0].ToString().ToLower() + " " + but.Text[1].ToString()))
                {
                    response = response.Replace((but.Text[0].ToString().ToLower() + " " + but.Text[1].ToString()), "**");
                }
                else if (response.Contains(but.Text[1] + " " + but.Text[0].ToString()))
                {
                    response = response.Replace((but.Text[0] + " " + but.Text[1].ToString()), "**");
                }
                else if (response.Contains(but.Text[1] + but.Text[0].ToString()))
                {
                    response = response.Replace((but.Text[0] + but.Text[1].ToString()), "**");
                }
            }

            return response;
        }
    }
}
