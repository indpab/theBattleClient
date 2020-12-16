using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Interpreter
{
    class CommandExpression : Expression
    {
        TextBox textBox;

        public void setTextBox(TextBox textBox)
        {
            this.textBox = textBox;
        }

        public override string Interpret(string message)
        {
            string response = "Unknown command";
            if (message[0].Equals('/'))
            {
                message = message[1..];
                if (message.Equals("red"))
                {
                    response = "Color changed to Red";
                    textBox.ForeColor = Color.Red;
                }
                else if (message.Equals("green"))
                {
                    response = "Color changed to Green";
                    textBox.ForeColor = Color.Green;
                }
                else if (message.Equals("blue"))
                {
                    response = "Color changed to Blue";
                    textBox.ForeColor = Color.Blue;
                }
                else if (message.Equals("darkmode"))
                {
                    response = "Dark mode activated !";
                    textBox.ForeColor = Color.White;
                    textBox.BackColor = Color.Black;
                }
                else if (message.Equals("help"))
                {
                    response = "Commands list: /red /green /blue /darkmode /help";
                }
            }
            else
            {
                return message;
            }

            return response;
        }
    }
}
