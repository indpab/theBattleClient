using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Iterator
{
    public interface Iterator
    {
        public abstract object Current();
        public abstract object Next();
        public bool MoveNext();
        public int Count();


    }
}
