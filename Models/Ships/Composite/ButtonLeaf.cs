using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Composite
{
    public class ButtonLeaf : ButtonComponent
    {
        public ButtonLeaf(Button button) : base(button)
        {

        }

        public override void UpdateButton()
        {
            throw new NotImplementedException();
        }
    }
}
