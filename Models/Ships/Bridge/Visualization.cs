using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Bridge
{
    public abstract class Visualization
    {
        public abstract List<Button> draw(List<Button> but, Decorator.IShip ship);
    }
}