using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class SmallShipFactory : AbstractShipFactory
    {
        public SmallShipFactory(string token, string roomId)
            : base(token, roomId)
        {
        }

        public override Submarine CreateSubmarine(int x, int y, bool horizontal)
        {
            return new SmallSubmarine(_token, _roomId, x, y, horizontal);
        }

        public override Destroyer CreateDestroyer(int x, int y, bool horizontal)
        {
            return new SmallDestroyer(_token, _roomId, x, y, horizontal);
        }
    }
}
