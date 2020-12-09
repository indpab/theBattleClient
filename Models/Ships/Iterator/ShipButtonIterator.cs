using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TheBattleShipClient.Models.Ships.Composite;

namespace TheBattleShipClient.Models.Ships.Iterator
{
    class ShipButtonIterator : Iterator
    {
        private ButtonComposite _buttonComposite;
        private int _count;
        public ShipButtonIterator(Ship ship)
        {
            _buttonComposite = (ButtonComposite)ship.button;
            _count = 0;
        }

        public int Count()
        {
            return _buttonComposite.GetNumberOfChildren() + 1;   
        }


        public object Current()
        {
            if (_count == 0)
            {
                return _buttonComposite;
            }
            return _buttonComposite.GetChild(_count);
        }

        public bool MoveNext()
        {
            if (_count++<Count())
            {
                _count++;
                return true;
            }
            return false;

        }

        public object Next()
        {
            if (MoveNext())
            {
                return Current();
            }
            return false;
        }

        public List<Button> GetAsList()
        {
            List<Button> buttonsList = new List<Button>();
            while (MoveNext())
            {
                buttonsList.Add(((ButtonComponent)this.Current()).GetButton());
            }
            return buttonsList;
        }


    }
}
