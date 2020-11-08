using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    class ColorBlue : Visualization
    {
        public override List<Button> draw(List<Button> buttons, Decorator.IShip ship)
        {
            foreach (var but in buttons)
            {
                but.Text = ship.getSkin();
                but.ForeColor = Color.Blue;
            }
            return buttons;
        }
    }
}
