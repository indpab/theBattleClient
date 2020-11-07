using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;

namespace TheBattleShipClient.Models.Ships
{
    [Serializable]
    public class SmallSubmarine : Submarine
    {
        public SmallSubmarine(string token, string roomId, int x, int y, bool horizontal)
            : base(token, roomId, x, y, horizontal, 1)
        {
        }

        public override async Task Create()
        {
            var ship = await Service.CreateShip(_token, _roomId, X, XOffset, Y, YOffset, 5);
            this.Id = ship.Id;
            this.HP = ship.HP;
        }
    }
}
