using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class LargeShipFactory : AbstractShipFactory
    {
        public LargeShipFactory(string token, string roomId)
            : base(token, roomId)
        {

        }
        public override Submarine CreateSubmarine(int x, int y, bool horizontal)
        {
            return new LargeSubmarine(_token, _roomId, x, y, horizontal);
        }

        public override Destroyer CreateDestroyer(int x, int y, bool horizontal)
        {
            return new LargeDestroyer(_token, _roomId, x, y, horizontal);
        }
    }
}
