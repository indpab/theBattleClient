using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    class ColorGreen : Visualization
    {
        public override TextBox draw(TextBox textBox, Decorator.IShip ship)
        {
            textBox.Text = ship.getSkin();
            textBox.ForeColor = Color.Green;
            return textBox;
        }
    }
}
