using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    abstract class Visualization
    {
        public abstract TextBox draw(TextBox textBox, Decorator.IShip ship);
    }
}