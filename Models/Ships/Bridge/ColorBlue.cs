using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    class ColorBlue : Visualization
    {
        public override TextBox draw(TextBox textBox, Decorator.IShip ship)
        {
            textBox.Text = ship.getSkin();
            textBox.ForeColor = Color.Blue;
            return textBox;
        }
    }
}
