using System;
using System.Collections.Generic;
using System.Text;

namespace TheBattleShipClient.Models.Ships.Factories
{
    public class MediumShipFactory : AbstractShipFactory
    {
        public MediumShipFactory(string token, string roomId)
            : base(token, roomId)
        {
        }

        public override Submarine CreateSubmarine(int x, int y, bool horizontal)
        {
            return new MediumSubmarine(_token, _roomId, x, y, horizontal);
        }

        public override Destroyer CreateDestroyer(int x, int y, bool horizontal)
        {
            return new MediumDestroyer(_token, _roomId, x, y, horizontal);
        }
    }
}
