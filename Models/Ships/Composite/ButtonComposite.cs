using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TheBattleShipClient.Models.Ships.Composite
{
    public class ButtonComposite : ButtonComponent
    {
        private List<ButtonComponent> _children = new List<ButtonComponent>();
        public ButtonComposite(Button button) : base(button)
        {

        }
        public override void UpdateButton()
        {
            
        }
        public int GetNumberOfChildren()
        {
            return _children.Count;
        }

        public void AddChild(ButtonComponent button)
        {
            _children.Add(button);
        }

        public ButtonComponent GetChild(int index)
        {
            return _children[index];
        }

        public void RemoveChild(ButtonComponent button)
        {
            _children.Remove(button);
        }
    }
}
