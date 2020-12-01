using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Composite
{
    public abstract class ButtonComponent
    {
        Button button;

        protected ButtonComponent(Button button)
        {
            this.button = button;
        }

        public abstract void UpdateButton();
    }
}
