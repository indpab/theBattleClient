using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    class ColorRed : Visualization
    {
        public override TextBox draw(TextBox textBox, Decorator.IShip ship)
        {
            textBox.Text = ship.getSkin();
            textBox.ForeColor = Color.Red;
            return textBox;
        }
    }
}
