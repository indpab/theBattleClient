using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    class ColorGreen : Visualization
    {
        public override List<Button> draw(List<Button> buttons, Decorator.IShip ship)
        {
            foreach (var but in buttons)
            {
                but.Text = ship.getSkin();
                but.ForeColor = Color.Green;
            }
            return buttons;
        }
    }
}
